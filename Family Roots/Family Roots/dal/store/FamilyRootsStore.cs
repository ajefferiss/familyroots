namespace Family_Roots.DAL.Store
{
    using DatabaseWrapper.Core;
    using Family_Roots.DAL.Store.Entities;
    using System.IO;
    using Watson.ORM.Sqlite;

    /// <summary>
    /// Provides interactions with the datastore entities.
    /// </summary>
    public class FamilyRootsStore
    {
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private DatabaseSettings settings;
        private WatsonORM orm;

        /// <summary>
        /// Initializes a new instance of the <see cref="FamilyRootsStore"/> class.
        /// </summary>
        /// <param name="dbPath">Absolute path on the file system for the database.</param>
        public FamilyRootsStore(string dbPath)
        {
            Logger.Info("Creating datastore under {0}", dbPath);
            this.settings = new DatabaseSettings(dbPath);
            this.orm = new WatsonORM(this.settings);
            this.orm.InitializeDatabase();

            this.CreateSchema();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FamilyRootsStore"/> class.
        /// </summary>
        public FamilyRootsStore()
            : this(Path.Combine(MainWindow.DataDirectory, "familyRoots.db"))
        {
        }

        /// <summary>
        /// Adds a new <see cref="Person"/> to the datastore.
        /// </summary>
        /// <param name="person">The <see cref="Person"/> to add.</param>
        /// <returns>An instance of <see cref="Person"/> as it is stored.</returns>
        public Person AddPerson(Person person)
        {
            return this.orm.Insert<Person>(person);
        }

        /// <summary>
        /// Adds a new <see cref="DatePlace"/> to the datastore.
        /// </summary>
        /// <param name="datePlace">The <see cref="DatePlace"/> to add.</param>
        /// <returns>An instance of <see cref="DatePlace"/> as it is stored.</returns>
        public DatePlace AddDatePlace(DatePlace datePlace)
        {
            return this.orm.Insert<DatePlace>(datePlace);
        }

        private void CreateSchema()
        {
            Logger.Info("Creating database schema");
            this.orm.InitializeTables(
                [
                    typeof(DatePlace),
                    typeof(DatePlaceEntity),
                    typeof(Contact),
                    typeof(Address),
                    typeof(Adoption),
                    typeof(Event),
                    typeof(Person),
                ]);
        }
    }
}
