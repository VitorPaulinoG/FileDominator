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
        Directories.AddRange(folderManager.FolderNames);
        
        // Usar Data Biding Aqui (Quando Souber)
        fileDirsListBox.Items.Clear();
        foreach (string item in Directories)
        {
            fileDirsListBox.Items.Add(item);
        }
    }

    private void RemoveDirButton_Click(object sender, RoutedEventArgs e)
    {
        // Usar Data Biding Aqui (Quando Souber)
        foreach (var item in fileDirsListBox.SelectedItems)
        {
            Directories.Remove((string)item);
        }
        fileDirsListBox.Items.Clear();
        foreach (string item in Directories)
        {
            fileDirsListBox.Items.Add(item);
        }
    }


    private void AddFilePatternsButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void RemoveFilePatternsButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void FileListButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void RenameFilesButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void MoveFilesButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void CopyFilesButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void DeleteFilesButton_Click(object sender, RoutedEventArgs e)
    {

    }
}