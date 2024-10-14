using Family_Roots.datastore.schema;
using SQLite;
using System.IO;

namespace Family_Roots.datastore
{
    public class DatabaseHandler
    {
        private SQLiteConnection _db;

        public DatabaseHandler(string dbPath)
        {
            var directory = Path.GetDirectoryName(dbPath);
            if (!String.IsNullOrEmpty(directory) && !Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            _db = new SQLiteConnection(dbPath);

            CreateTable();
        }

        public DatabaseHandler() : this(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "FamilyRoots", "familyroots.db"))
        {
        }

        private void CreateTable()
        {
            _db.CreateTable<DatePlace>();
            _db.CreateTable<Adoption>();
            _db.CreateTable<AdoptedPerson>();
            _db.CreateTable<ContactDetail>();
            _db.CreateTable<Address>();
            _db.CreateTable<Event>();
            _db.CreateTable<Destination>();
            _db.CreateTable<LocationInfo>();
            _db.CreateTable<Census>();
            _db.CreateTable<Person>();
        }
    }
}
