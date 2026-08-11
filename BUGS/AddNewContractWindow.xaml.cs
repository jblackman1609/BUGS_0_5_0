using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BUGS.Data;
using BUGS.Services;

namespace BUGS
{
    /// <summary>
    /// Interaction logic for AddNewContractWindow.xaml
    /// </summary>
    public partial class AddNewContractWindow : Window
    {
        private readonly ContractViewModel viewModel;
        
        public AddNewContractWindow()
        {
            InitializeComponent();
            viewModel = new();
            DataContext = viewModel;

            PropDesc.ItemsSource = viewModel.PropertyDescriptions;
            BondTypes.ItemsSource = viewModel.BondTypes;
            RenewalFees.ItemsSource = viewModel.RenewalFees;
            TransferFees.ItemsSource = viewModel.TransferFees;
            ContractPrice.ItemsSource = viewModel.ContractPrices;
        }

        private void SaveContract_Click(object sender, RoutedEventArgs e)
        {
           Contract contract = new Contract()
           {
               PropDescription = viewModel.SelectedDescription,
               Purchaser = viewModel.Purchaser,
               Phone = viewModel.Phone,
               CustStreetAdd = viewModel.CustStreetAdd,
               CustCity = viewModel.CustCity,
               CustState = viewModel.CustState,
               CustZipCode = viewModel.CustZipCode,
               PropStreetAdd = viewModel.PropStreetAdd,
               PropCity = viewModel.PropCity,
               PropState = viewModel.PropState,
               PropZipCode = viewModel.PropZipCode,
               BondType = viewModel.SelectedBondType,
               ContractPrice = viewModel.SelectedContractPrice,
               RenewalFee = viewModel.SelectedRenewalFee,
               TransferFee = viewModel.SelectedTransferFee
           };       

           ContractService service = new ContractService();
           try
            {
                service.AddContract(contract);
                MessageBox.Show($"Contract: {contract.PropDescription} worked.");
                this.Close();
            }

            catch
            {
                MessageBox.Show($"Contract: {contract.PropDescription} failed to save.");   
            }         
        }
    }
}

       
        