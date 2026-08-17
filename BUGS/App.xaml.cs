using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;
using BUGS.Windows;
using Microsoft.Extensions.Configuration;

namespace BUGS;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    [Required]
    public IConfiguration Configuration { get; private set; }

    public App()
    {
        var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json", false, true);

        Configuration = builder.Build();

        MainWindow mainWindow = new();
        mainWindow.Show();
    }
}

