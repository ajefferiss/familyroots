using Family_Roots.dal.import;
using Family_Roots.dal.store;
using System.IO;
using System.Windows;

namespace Family_Roots
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly string DataDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FamilyRoots");
        private FamilyRootsStore _db = new FamilyRootsStore();

        public MainWindow()
        {
            InitializeComponent();

            if (!Directory.Exists(DataDirectory))
            {
                Directory.CreateDirectory(DataDirectory);
            }
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
                var importer = new GEDComImporter(_db);

                try
                {
                    importer.importResource(dialog.FileName);
                }
                catch (ImportException ex)
                {

                }
            }
        }
    }
}