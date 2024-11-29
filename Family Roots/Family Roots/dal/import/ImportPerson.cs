using Family_Roots.dal.store;

namespace Family_Roots.dal.import
{
    public class ImportPerson
    {
        public Person Person { get; set; }
        public DatePlace? Birth { get; set; }
        public DatePlace? Death { get; set; }
        public Address? Address { get; set; }
        public List<AdoptedPerson> AdoptedPersons { get; set; } = new List<AdoptedPerson>();
        public List<Adoption> Adoptions { get; set; } = new List<Adoption>();
        public List<Events> Events { get; set; } = new List<Events>();
        public List<EventDates> EventDates { get; set; } = new List<EventDates>();
        public List<DatePlace> Census { get; set; } = new List<DatePlace>();
        public List<DatePlace> Destination { get; set; } = new List<DatePlace>();
        public List<Residence> Residences { get; set; } = new List<Residence>();
        public List<Migration> Migrations { get; set; } = new List<Migration>();
        public List<BecomingCitizen> BecomingCitizens { get; set; } = new List<BecomingCitizen>();
    }
}
