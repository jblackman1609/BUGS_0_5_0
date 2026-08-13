using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BUGS.Data
{
    public class WordDocSettings
    {
        public HeaderSettings HeaderSettings { get; set; } = new();
        public BodySettings BodySettings { get; set; } = new();
    }

    public class HeaderSettings
    {
        public CompanyName CompanyName { get; set; } = new();
        public CompanyAddress CompanyAddress { get; set; } = new();
        public CompanyContact CompanyContact { get; set; } = new();
        public ShortText ShortText { get; set; } = new();
        public BoxText BoxText { get; set; } = new();
    }

    public class BodySettings
    {
        public PurchaserInfo PurchaserInfo { get; set; } = new();
        public PropertyInfo PropertyInfo { get; set; } = new();
        public ContractBody ContractBody { get; set; } = new();
    }

    public class CompanyName
    {
        public string Text { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }

    public class CompanyAddress
    {
        public string Text { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }

    public class CompanyContact
    {
        public string Text { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }

    public class ShortText
    {
        public string Text { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
    }

    public class BoxText
    {
        public string Text { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public string Border { get; set; } = string.Empty;
    }

    public class PurchaserInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
    }

    public class PropertyInfo
    {
        public string PropertyDescription { get; set; } = string.Empty;
        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
    }

    public class ContractBody
    {
        public string EffectiveDate { get; set; } = string.Empty;
        public string ThroughDate { get; set; } = string.Empty;
        public string Cost { get; set; } = string.Empty;
        public string Paragraph1 { get; set; } = string.Empty;
        public string Paragraph2 { get; set; } = string.Empty;
        public string Paragraph3 { get; set; } = string.Empty;
        public string Paragraph4 { get; set; } = string.Empty;
        public string Paragraph5 { get; set; } = string.Empty;
        public string Paragraph6 { get; set; } = string.Empty;
        public string Paragraph7 { get; set; } = string.Empty;
        public string RenewaFeePara8 { get; set; } = string.Empty;
        public string Paragraph9 { get; set; } = string.Empty;
        public string TransferFeePara10 { get; set; } = string.Empty;
    }
}