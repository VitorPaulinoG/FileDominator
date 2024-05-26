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
using System.Windows.Shapes;

namespace View.Menus
{
    /// <summary>
    /// Interaction logic for MatchingFilesList.xaml
    /// </summary>
    public partial class MatchingFilesList : Window
    {
        List<string> _matchingFiles;
        public MatchingFilesList(List<string> matchingFiles)
        {
            InitializeComponent();
            this._matchingFiles = matchingFiles;
            // Usar DataBinding Aqui
            foreach (var matchingFile in _matchingFiles)
            {
                matchingFilesListBox.Items.Add(matchingFile);
            }


        }
    }
}
