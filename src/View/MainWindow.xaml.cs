using Microsoft.Win32;
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

namespace View;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private List<string> _directories = new List<string>();
    public List<string> Directories 
    { 
        get 
        { 
            return _directories; 
        } 
        private set
        {
            _directories = value;
        }
    }  
    public MainWindow()
    {
        InitializeComponent();
    }

    private void AddDirButton_Click(object sender, RoutedEventArgs e)
    {
        OpenFolderDialog folderManager = new OpenFolderDialog();
        folderManager.Multiselect = true; 
        folderManager.ShowDialog();
    }
}