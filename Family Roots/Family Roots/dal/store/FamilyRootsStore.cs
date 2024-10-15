using Family_Roots.datastore.schema;
using SQLite;
using System.IO;

namespace Family_Roots.dal.store
{
    public class FamilyRootsStore
    {
        private SQLiteConnection _db;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public FamilyRootsStore(string dbPath)
        {
            Logger.Info("Creating datastore under {0}", dbPath);
            _db = new SQLiteConnection(dbPath);

            CreateTable();
        }

        public FamilyRootsStore() : this(Path.Combine(MainWindow.DataDirectory, "familyroots.db"))
        {
        }

        private void CreateTable()
        {
            Logger.Info("Creating table structure");

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

        public void AddPerson(Person person)
        {
            _db.Insert(person);
        }
    }
}
