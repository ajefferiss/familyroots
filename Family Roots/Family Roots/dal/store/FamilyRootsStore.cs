using DatabaseWrapper.Core;
using System.IO;
using Watson.ORM.Sqlite;

namespace Family_Roots.dal.store
{
    public class FamilyRootsStore
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private DatabaseSettings settings;
        private WatsonORM orm;

        public FamilyRootsStore(string dbPath)
        {
            Logger.Info("Creating datastore under {0}", dbPath);
            settings = new DatabaseSettings(dbPath);
            orm = new WatsonORM(settings);
            orm.InitializeDatabase();

            CreateSchema();
        }

        public FamilyRootsStore() : this(Path.Combine(MainWindow.DataDirectory, "familyroots.db"))
        {
        }

        public Person AddPerson(Person person)
        {
            return orm.Insert<Person>(person);
        }

        public DatePlace AddDatePlace(DatePlace datePlace)
        {
            return orm.Insert<DatePlace>(datePlace);
        }

        private void CreateSchema()
        {
            Logger.Info("Creating database schema");
            orm.InitializeTables(
                new List<Type>
                {
                    typeof(DatePlace),
                    typeof(Address),
                    typeof(Adoption),
                    typeof(AdoptedPerson),
                    typeof(LocationInfo),
                    typeof(Census),
                    typeof(Destination),
                    typeof(Person),
                    typeof(Events),
                    typeof(EventDates)
                }
            );
        }
    }
}
