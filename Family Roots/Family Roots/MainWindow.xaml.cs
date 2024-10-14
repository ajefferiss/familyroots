using GeneGenie.Gedcom.Parser;
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
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace Family_Roots
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Open_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private void MenuItem_Import_Clicked(object sender, RoutedEventArgs e)
        {
            var dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.FileName = "Document";
            dialog.DefaultExt = ".ged";
            dialog.Filter = "GEDCom documents (.ged)|*.ged";

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                string filename = dialog.FileName;
                var gedcomReader = GedcomRecordReader.CreateReader(filename);
                var helens = gedcomReader.Database.Individuals.FindAll(i => i.Names.First().Given.StartsWith("Helen"));
                
                foreach (var indi in helens)
                {
                    var family = indi.GetFamily();
                    var children = gedcomReader.Database.Individuals.FindAll(i => family.Children.Contains(i.XrefId));
                }
            }
        }
    }
}