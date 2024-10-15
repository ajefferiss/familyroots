using SQLite;
using SQLiteNetExtensions.Attributes;

namespace Family_Roots.datastore.schema
{
    [Table("datePlace")]
    public class DatePlace
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("date")]
        public string Date { get; set; } = String.Empty;

        [Column("place")]
        public string Place { get; set; } = String.Empty;

        [Column("latitude")]
        public string Latitude { get; set; } = String.Empty;

        [Column("longitude")]
        public string Longitude { get; set; } = String.Empty;

        [Column("note")]
        public string Note { get; set; } = String.Empty;

        [Column("description")]
        public string Description { get; set; } = String.Empty;
    }

    [Table("adoption")]
    public class Adoption
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey(typeof(DatePlace))]
        public int DatePlace { get; set; }

        [Column("type")]
        public string Type { get; set; } = String.Empty;

        [Column("note")]
        public string Note {  get; set; } = String.Empty;

        [ManyToMany(typeof(AdoptedPerson))]
        public List<Person> Persons { get; set; } = new List<Person>();
    }

    [Table("adoptedPerson")]
    public class AdoptedPerson
    {
        [ForeignKey(typeof(Adoption))]
        public int AdoptionId { get; set; }

        [ForeignKey(typeof(Person))]
        public int PersonId { get; set; }
    }

    [Table("person")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("gedId")]
        public string GEDId { get; set; } = String.Empty;

        [Column("uuid")]
        public string UUID { get; set; } = String.Empty;

        [Column("idNumber")]
        public string IdNumber { get; set; } = String.Empty;

        [Column("firstName")]
        public string FirstName { get; set; } = String.Empty;

        [Column("lastName")]
        public string LastName { get; set; } = String.Empty;

        [Column("title")]
        public string Title { get; set; } = String.Empty;

        [Column("gender")]
        public string Gender { get; set; } = String.Empty;

        [ForeignKey(typeof(DatePlace))]
        public int Birth { get; set; }

        [ForeignKey(typeof(DatePlace))]
        public int Death { get; set; }

        [ForeignKey(typeof(DatePlace))]
        public int Buried { get; set; }

        [ForeignKey(typeof(DatePlace))]
        public int Baptized { get; set; }

        [Column("education")]
        public string Education { get; set; } = String.Empty;

        [Column("religion")]
        public string Religion { get; set; } = String.Empty;

        [Column("nationality")]
        public string Nationality { get; set; } = String.Empty;

        [Column("note")]
        public string Note { get; set; } = String.Empty;

        [Column("occupation")]
        public string Occupation { get; set; } = String.Empty;

        [Column("health")]
        public string Health {  get; set; } = String.Empty;

        [ForeignKey(typeof(Address))]
        public int Address { get; set; }

        [ForeignKey(typeof(DatePlace))]
        public int Graduation { get; set; }

        [OneToMany]
        public List<Census> Census { get; set; } = new List<Census>();

        [OneToMany]
        public List<LocationInfo> LocationInfos { get; set; } = new List<LocationInfo>();

        [OneToMany]
        public List<Destination> Destinations { get; set; } = new List<Destination>();

        [OneToMany]
        public List<Event> Events { get; set; } = new List<Event>();
    }

    [Table("address")]
    public class Address
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("street")]
        public string Street { get; set; } = String.Empty;

        [Column("city")]
        public string City { get; set; } = String.Empty;

        [Column("state")]
        public string State { get; set; } = String.Empty;

        [Column("zipcode")]
        public string ZipCode { get; set; } = String.Empty;

        [Column("country")]
        public string Country { get; set; } = String.Empty;

        [ForeignKey(typeof(ContactDetail))]
        public int Phone { get; set; }

        [ForeignKey(typeof(ContactDetail))]
        public int Fax { get; set; }

        [ForeignKey(typeof(ContactDetail))]
        public int Email { get; set; }

        [ForeignKey(typeof(ContactDetail))]
        public int Web { get; set; }
    }

    [Table("contactDetail")]
    public class ContactDetail
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("type")]
        public string Type { get; set; } = String.Empty;

        [Column("value")]
        public string Value { get; set; } = String.Empty;
    }

    [Table("census")]
    public class Census
    {
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey(typeof(DatePlace))]
        public int DatePlace { get; set; }

        [ForeignKey(typeof(Person))]
        public int Person { get; set; }

    }

    [Table("locationInfo")]
    public class LocationInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("type")]
        public string Type { get; set; } = String.Empty;

        [ForeignKey(typeof(DatePlace))]
        public int DatePlace { get; set; }

        [ForeignKey(typeof(Person))]
        public int Person { get; set; }
    }

    [Table("destination")]
    public class Destination
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [ForeignKey(typeof(DatePlace))]
        public int DatePlace { get; set; }

        [ForeignKey(typeof(Person))]
        public int Person { get; set; }
    }

    [Table("event")]
    public class Event
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [Column("event")]
        public string Detail {  get; set; } = String.Empty;

        [ForeignKey(typeof (DatePlace))]
        public int DatePlace { get; set; }

        [ForeignKey(typeof(Person))]
        public int Person { get; set; }
    }
}