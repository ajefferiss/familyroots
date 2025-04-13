namespace Family_Roots
{
    using Family_Roots.DAL.Import;
    using Family_Roots.DAL.Store;
    using System.IO;
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly string DataDirectory = Path.Join(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), Properties.Settings.Default.ConfigDirectory);
        private ApplicationDbContext _db = new ApplicationDbContext();

        public MainWindow()
        {
            InitializeComponent();

            if (!Directory.Exists(DataDirectory))
            {
                Directory.CreateDirectory(DataDirectory);
            }

            _db.Database.EnsureCreated();
        }

        private void MenuItem_Open_Clicked(object sender, RoutedEventArgs e)
        {

        }

        private async void MenuItem_Import_Clicked(object sender, RoutedEventArgs e)
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
                    await importer.ImportResource(dialog.FileName);
                }
                catch (ImportException ex)
                {

                }
            }
        }

        private void MenuItem_Exit_Clicked(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}