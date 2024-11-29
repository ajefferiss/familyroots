using DatabaseWrapper.Core;
using Watson.ORM.Core;

namespace Family_Roots.dal.store
{
    [Table("datePlace")]
    public class DatePlace
    {
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Date { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Place { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Latitude { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Longitude { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Note { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Description { get; set; }
    }

    [Table("address")]
    public class Address
    {
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? AddressLine1 { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? AddressLine2 { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? AddressLine3 { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? City { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? State { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? PostalCode { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Country { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Phone { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Fax { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Email { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Web { get; set; }
    }

    [Table("adoption")]
    public class Adoption
    {
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        [Column(DataTypes.Int)]
        public int DatePlace { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Type { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Note { get; set; }
    }

    [Table("adoptedPerson")]
    public class AdoptedPerson()
    {
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        [Column(DataTypes.Int, false)]
        public int AdoptionId { get; set; }

        [Column(DataTypes.Int, false)]
        public int PersonId { get; set; }
    }

    [Table("census")]
    public class Census
    {
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        [Column(DataTypes.Int, false)]
        public int PersonId { get; set; }

        [Column(DataTypes.Int, false)]
        public int DatePlace { get; set; }
    }

    [Table("destination")]
    public class Destination
    {
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        [Column(DataTypes.Int, false)]
        public int PersonId { get; set; }

        [Column(DataTypes.Int, false)]
        public int DatePlace { get; set; }

    }

    [Table("residence")]
    public class Residence
    {
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        [Column(DataTypes.Int, false)]
        public int PersonId { get; set; }

        [Column(DataTypes.Int, false)]
        public int DatePlace { get; set; }
    }

    [Table("migration")]
    public class Migration
    {
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        [Column(DataTypes.Int, false)]
        public int PersonId { get; set; }

        [Column(DataTypes.Int, false)]
        public int DatePlace { get; set; }

        [Column(DataTypes.Int, false)]
        public int Type { get; set; }   // 1 - emigrated, 2 - immigrated
    }

    [Table("citizenship")]
    public class BecomingCitizen
    {
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        [Column(DataTypes.Int, false)]
        public int PersonId { get; set; }

        [Column(DataTypes.Int, false)]
        public int DatePlace { get; set; }
    }

    [Table("person")]
    public class Person
    {
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? GEDId { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? UID { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? IdNumber { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? FirstName { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? LastName { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Title { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Gender { get; set; }

        [Column(DataTypes.Int)]
        public int Birth { get; set; }

        [Column(DataTypes.Int)]
        public int Death { get; set; }

        [Column(DataTypes.Boolean)]
        public bool Dead { get; set; }

        [Column(DataTypes.Int)]
        public int Buried { get; set; }

        [Column(DataTypes.Int)]
        public int Baptized { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Education { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Religion { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Nationality { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Note { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Occupation { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Health { get; set; }

        [Column(DataTypes.Int)]
        public int Address { get; set; }

        [Column(DataTypes.Int)]
        public int GraduationDate { get; set; }
    }

    [Table("events")]
    public class Events
    {
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        [Column(DataTypes.Nvarchar, 2048)]
        public string? Event { get; set; }

        [Column(DataTypes.Int, false)]
        public int Person { get; set; }
    }

    [Table("eventDates")]
    public class EventDates
    {
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        [Column(DataTypes.Int, false)]
        public int Event;

        [Column(DataTypes.Int, false)]
        public int DatePlace;
    }
}