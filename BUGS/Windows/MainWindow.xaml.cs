using System.Text;
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
using BUGS.Windows;

namespace BUGS;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly ContractGridService service;

    public MainWindow()
    {
        InitializeComponent();

        BUGSContext context = new BUGSContext();
        ContractRepository repo = new ContractRepository(context);
        service = new ContractGridService(repo);        
        ContractDataGrid.ItemsSource = service.GetContractGridView().Contracts;
    }

    private void AddNewContract_Click(object sender, RoutedEventArgs e)
    {
        Window addNewContractWindow = new Window(); 
        ContractViewModel viewModel = service.AddNewContractView();
        addNewContractWindow.DataContext = viewModel;
        
        addNewContractWindow.ShowDialog();
    }

    private void ExportWord_Click(object sender, RoutedEventArgs e)
    {
        
    }

    private void Refresh_Click(object sender, RoutedEventArgs e)
    {
        
    }
}