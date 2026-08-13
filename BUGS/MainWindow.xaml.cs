using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using BUGS.Data;
using BUGS.Services;
using DocumentFormat.OpenXml.Office2016.Drawing.Command;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BUGS;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly ContractService service;
    //private readonly Contract model;
    //private WordDocSettings settings;
    //IConfiguration configuration;

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

    private void Export_Click(object sender, RoutedEventArgs e)
    {        
        if (sender is not null)
        {
            Button button = (Button)sender;
            Contract contract = (Contract)button.DataContext;

            ExportService export = new ExportService();
            export.ExportWord(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), contract);

            MessageBox.Show("Successfully created contract document.");
        }  
    }
}