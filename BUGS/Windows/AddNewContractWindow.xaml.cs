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
using BUGS.Models;
using BUGS.Services;

namespace BUGS.Windows
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
           
            BUGSContext context = new();
            ContractRepository repo = new ContractRepository(context);
            ContractGridService service = new ContractGridService(repo);

            ContractViewModel viewModel = new();
            viewModel = service.GetContractGridView();
            DataContext = viewModel;

            PropertyDesc.ItemsSource = viewModel.PropertyDescriptions;
            
        }

        private void SaveContract_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}