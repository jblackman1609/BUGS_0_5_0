using System.Configuration;
using System.Data;
using System.Windows;
using BUGS.Windows;

namespace BUGS;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
    }
}

