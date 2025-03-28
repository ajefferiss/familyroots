namespace Family_Roots.DAL.Store
{
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using Family_Roots.DAL.Store.Entities;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Provides interactions with the datastore entities.
    /// </summary>
    [SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:ElementsMustAppearInTheCorrectOrder", Justification = "Reviewed.")]
    public class FamilyRootsContext : DbContext
    {
        private string dbPath;

        /// <summary>
        /// Gets or sets the database set of the <see cref="Address"/> table.
        /// </summary>
        public DbSet<Address> Addresses { get; set; }

        /// <summary>
        /// Gets or sets the database set of the <see cref="Adoption"/> table.
        /// </summary>
        ///
        public DbSet<Adoption> Adoptions { get; set; }

        /// <summary>
        /// Gets or sets the database set of the <see cref="Contact"/> table.
        /// </summary>
        ///
        public DbSet<Contact> Contacts { get; set; }

        /// <summary>
        /// Gets or sets the database set of the <see cref="DatePlace"/> table.
        /// </summary>
        ///
        public DbSet<DatePlace> DatePlaces { get; set; }

        /// <summary>
        /// Gets or sets the database set of the <see cref="DatePlaceEntity"/> table.
        /// </summary>
        ///
        public DbSet<DatePlaceEntity> DatePlaceEntities { get; set; }

        /// <summary>
        /// Gets or sets the database set of the <see cref="Event"/> table.
        /// </summary>
        public DbSet<Event> Events { get; set; }

        /// <summary>
        /// Gets or sets the database set of the <see cref="Person"/> table.
        /// </summary>
        public DbSet<Person> Persons { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FamilyRootsContext"/> class.
        /// </summary>
        public FamilyRootsContext()
        {
            this.dbPath = Path.Join(MainWindow.DataDirectory, Properties.Settings.Default.DatabaseFile);
        }

        /// <summary>
        /// Configure EF to create a SQLite database file.
        /// </summary>
        /// <param name="options">Database options.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={this.dbPath}");
    }
}
