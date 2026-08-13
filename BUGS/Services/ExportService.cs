using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BUGS.Data;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Microsoft.Extensions.Configuration;

namespace BUGS.Services
{
    public class ExportService
    {
        private readonly WordDocSettings settings;

        public ExportService()
        {
            settings = new WordDocSettings();
            App.Configuration!.GetSection("WordDocSettings").Bind(settings);
        }

        public void ExportWord(string folder, Contract contract)
        {
            string finalFileName = Path.Combine(folder, $"{contract.PropStreetAdd}.docx");

            using (WordprocessingDocument wordDoc = WordprocessingDocument
            .Create(finalFileName, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDoc.AddMainDocumentPart();
                mainPart.Document = new Document(new Body());
                string headerPartId;
                
                BuildHeader(mainPart, settings, out headerPartId);    
                AddHeaderToBody(mainPart, headerPartId); 
                AddTextToBody(mainPart, settings, contract);

                mainPart.Document.Save();                           
            }
        }

        private void BuildHeader(MainDocumentPart mainPart, WordDocSettings settings, out string id)
        {
            HeaderPart headerPart = mainPart.AddNewPart<HeaderPart>();
            id = mainPart.GetIdOfPart(headerPart);

            Header header = new();
            
            Paragraph paragraph = new Paragraph(
                new ParagraphProperties(new Justification() { Val = JustificationValues.Center }), 
                new Run(
                    new RunProperties(
                        new FontSize() { Val = settings.HeaderSettings.CompanyName.Size },
                        new Color() { Val = settings.HeaderSettings.CompanyName.Color }
                    ),
                    new Text(settings.HeaderSettings.CompanyName.Text)),
                new Run(new Break()),
                new Run(
                    new RunProperties(
                        new FontSize() { Val = settings.HeaderSettings.CompanyAddress.Size },
                        new Color() { Val = settings.HeaderSettings.CompanyAddress.Color }
                    ), 
                    new Text(settings.HeaderSettings.CompanyAddress.Text)),
                new Run(new Break()),
                new Run(
                    new RunProperties(
                        new FontSize() { Val = settings.HeaderSettings.CompanyContact.Size },
                        new Color() { Val = settings.HeaderSettings.CompanyContact.Color }
                    ),
                    new Text(settings.HeaderSettings.CompanyContact.Text)),
                new Run(new Break()),
                new Run(
                    new RunProperties(
                        new FontSize() { Val = settings.HeaderSettings.ShortText.Size },
                        new Color() { Val = settings.HeaderSettings.ShortText.Color }
                    ),
                    new Text(settings.HeaderSettings.ShortText.Text)),
                new Run(new Break()));

            Paragraph boxParagraph = new Paragraph(
                new ParagraphProperties(new Justification() { Val = JustificationValues.Left }),
                new Run(
                    new RunProperties(
                        new FontSize() { Val = settings.HeaderSettings.BoxText.Size },
                        new Color() { Val = settings.HeaderSettings.BoxText.Color }
                    ),
                    new Text(settings.HeaderSettings.BoxText.Text)));
               

            header.Append(paragraph);
            header.Append(boxParagraph);
            headerPart.Header = header;
            headerPart.Header.Save();
        }

        private void AddHeaderToBody(MainDocumentPart mainPart, string headerPartId)
        {
            SectionProperties sectionProps = new SectionProperties();
            HeaderReference headerReference = new HeaderReference()
            {
                Type = HeaderFooterValues.Default,
                Id = headerPartId
            };

            sectionProps.Append(headerReference);
            mainPart.Document!.Body!.Append(sectionProps);
        }

        private void AddTextToBody(MainDocumentPart mainPart, WordDocSettings settings, Contract contract)
        {
            Paragraph infoParagraph = new();
            ParagraphProperties paraProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Left});
            
            Run informationRun = new();
            RunProperties informationRunProps = new RunProperties();
            informationRunProps.Append(new FontSize() { Val = settings.HeaderSettings.BoxText.Size });
            informationRunProps.Append(new Color() { Val = settings.HeaderSettings.BoxText.Color });
            informationRun.Append(informationRunProps);
            informationRun.Append(new Text(AddDynamicValues(settings.BodySettings.PurchaserInfo.Name, contract.Purchaser)));
            informationRun.Append(new TabChar());
            informationRun.Append(new Text(AddDynamicValues(settings.BodySettings.PurchaserInfo.Phone, contract.Phone)));
            informationRun.Append(new TabChar());
            informationRun.Append(new Text(AddDynamicValues(settings.BodySettings.PurchaserInfo.Email, contract.Email)));
            informationRun.Append(new Break());
            informationRun.Append(new Text(AddDynamicValues(settings.BodySettings.PropertyInfo.PropertyDescription, contract.PropDescription)));
            informationRun.Append(new Break());
            informationRun.Append(new Text(AddDynamicValues(settings.BodySettings.PropertyInfo.StreetAddress, contract.PropStreetAdd)));
            informationRun.Append(new Break());
            informationRun.Append(new Text(AddDynamicValues(settings.BodySettings.PropertyInfo.City, contract.PropCity)));
            informationRun.Append(new TabChar());
            informationRun.Append(new Text(AddDynamicValues(settings.BodySettings.PropertyInfo.State, contract.PropState)));
            informationRun.Append(new TabChar());
            informationRun.Append(new Text(AddDynamicValues(settings.BodySettings.PropertyInfo.ZipCode, contract.PropZipCode)));
            informationRun.Append(new Break());

            infoParagraph.Append(paraProperties);
            infoParagraph.Append(informationRun);
            mainPart.Document!.Body!.Append(infoParagraph);
            mainPart.Document.Save();

            Paragraph contractParagraph = new();
            ParagraphProperties contractProps = new ParagraphProperties(new Justification() { Val = JustificationValues.Both });

            Run dateAndCostRun = new();
            RunProperties contractRunProps = new RunProperties();
            contractRunProps.Append(new FontSize() { Val = settings.HeaderSettings.BoxText.Size });
            contractRunProps.Append(new Color() { Val = settings.HeaderSettings.BoxText.Color });
            dateAndCostRun.Append(contractRunProps);
            dateAndCostRun.Append(new Text(AddDynamicValues(settings.BodySettings.ContractBody.EffectiveDate, contract.EffectiveDate.ToString())));
            dateAndCostRun.Append(new TabChar());
            dateAndCostRun.Append(new Text(AddDynamicValues(settings.BodySettings.ContractBody.ThroughDate, contract.ThroughDate.ToString())));
            dateAndCostRun.Append(new TabChar());
            dateAndCostRun.Append(new Text(AddDynamicValues(settings.BodySettings.ContractBody.Cost, contract.ContractPrice)));
            dateAndCostRun.Append(new Break());

            Run contractBodyRun = new();
            RunProperties contractBodyRunProps = new RunProperties();
            contractRunProps.Append(new FontSize() { Val = settings.HeaderSettings.BoxText.Size });
            contractRunProps.Append(new Color() { Val = settings.HeaderSettings.BoxText.Color });
            contractBodyRun.Append(contractBodyRunProps);
            contractBodyRun.Append(new Text(settings.BodySettings.ContractBody.Paragraph1));
            contractBodyRun.Append(new Text(settings.BodySettings.ContractBody.Paragraph2));
            contractBodyRun.Append(new Text(settings.BodySettings.ContractBody.Paragraph3));
            contractBodyRun.Append(new Text(settings.BodySettings.ContractBody.Paragraph4));
            contractBodyRun.Append(new Text(settings.BodySettings.ContractBody.Paragraph5));
            contractBodyRun.Append(new Text(settings.BodySettings.ContractBody.Paragraph6));
            contractBodyRun.Append(new Text(settings.BodySettings.ContractBody.Paragraph7));
            contractBodyRun.Append(new Text(AddDynamicValues(settings.BodySettings.ContractBody.RenewaFeePara8, contract.RenewalFee)));
            contractBodyRun.Append(new Text(settings.BodySettings.ContractBody.Paragraph9));
            contractBodyRun.Append(new Text(AddDynamicValues(settings.BodySettings.ContractBody.TransferFeePara10, contract.TransferFee)));

            contractParagraph.Append(contractProps);
            contractParagraph.Append(dateAndCostRun);
            contractParagraph.Append(contractBodyRun); 
            
            
            mainPart.Document!.Body!.Append(contractParagraph); 
            mainPart.Document.Save();
        }

        private string AddDynamicValues(string input, string replace)
        {
            return input.Replace("[Placeholder]", replace);
        }
    }
}