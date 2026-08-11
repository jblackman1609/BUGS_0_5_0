using System.Diagnostics;
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
using BUGS.Services;
using Microsoft.EntityFrameworkCore;

namespace BUGS;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly ContractService service;

    public MainWindow()
    {
        InitializeComponent();
        service = new ContractService();
        ContractGrid.ItemsSource = service.GetContractsAsync();
    }

    private void AddNewContract_Click(object sender, RoutedEventArgs e)
    {
        AddNewContractWindow window = new AddNewContractWindow();
        window.ShowDialog();
    }

    private void Refresh_Click(object sender, RoutedEventArgs e)
    {
        MainWindow main = new MainWindow();
        this.Close();
        main.ShowDialog();        
    }
}