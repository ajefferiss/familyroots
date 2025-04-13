namespace Family_Roots.DAL.Import
{
    using Family_Roots.DAL.Store;
    using Family_Roots.DAL.Store.Entities;

    /// <summary>
    /// Holds information read from a import before it is stored within the <see cref="ApplicationDbContext"/>.
    /// </summary>
    public class ImportPerson
    {
        /// <summary>
        /// Gets or sets the Person being imported.
        /// </summary>
        public Person Person { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Address" /> for a imported person. Defaults to null.
        /// </summary>
        public Address? Address { get; set; } = null;

        /*
        public List<AdoptedPerson> AdoptedPersons { get; set; } = new List<AdoptedPerson>();
        public List<Adoption> Adoptions { get; set; } = new List<Adoption>();
        public List<Events> Events { get; set; } = new List<Events>();
        public List<EventDates> EventDates { get; set; } = new List<EventDates>();
        public List<DatePlace> Census { get; set; } = new List<DatePlace>();
        public List<DatePlace> Destination { get; set; } = new List<DatePlace>();
        public List<Residence> Residences { get; set; } = new List<Residence>();
        public List<Migration> Migrations { get; set; } = new List<Migration>();
        public List<BecomingCitizen> BecomingCitizens { get; set; } = new List<BecomingCitizen>();
        */
    }
}
