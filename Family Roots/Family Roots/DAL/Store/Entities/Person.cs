namespace Family_Roots.DAL.Store.Entities
{
    /// <summary>
    /// Table to represent a GEDCom parsed person.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the database ID.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the GEDCom ID.
        /// </summary>
        public string GEDId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Uid for a Person, defaults to a empty string.
        /// </summary>
        public string Uid { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ID Number for a person, defaults to a empty string.
        /// </summary>
        public string IdNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the persons first name, defaults to a empty string.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the persons last name, defaults to a empty string.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets gender, defaults to a empty string.
        /// </summary>
        public string Gender { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> id for the persons birth, defaults to null.
        /// </summary>
        public DatePlace? Birth { get; set; } = null;

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> id for persons death, defaults to null.
        /// </summary>
        public DatePlace? Death { get; set; } = null;

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> id for the date a person was buried, defaults to null.
        /// </summary>
        public DatePlace? Buried { get; set; } = null;

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> id for the date a person was baptized, defaults to null.
        /// </summary>
        public DatePlace? Baptized { get; set; } = null;

        /// <summary>
        /// Gets or sets the persons education, defaults to a empty string.
        /// </summary>
        public string Education { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the persons religion, defaults to a empty string.
        /// </summary>
        public string Religion { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the nationality for a person, defaults to a empty string.
        /// </summary>
        public string Nationality { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets any notes for the person, defaults to a empty string.
        /// </summary>
        public string Note { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets changed flag for a person, defaults to a empty string.
        /// </summary>
        public string Changed { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the occupation for a person, defaults to a empty string.
        /// </summary>
         public string Occupation { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets details of a persons health, defaults to a empty string.
        /// </summary>
         public string Health { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets title (Mr, Miss, Dr, etc) for the person, defaults to a empty string.
        /// </summary>
         public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the <see cref="Address"/> ID for the person, defaults to null.
        /// </summary>
         public Address? LastAddress { get; set; } = null;

        /// <summary>
        /// Gets or sets the <see cref="Adoption"/> ID for the person, defaults to null.
        /// </summary>
        public Adoption? Adopted { get; set; } = null;

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> ID for the graduation date, defaults to null.
        /// </summary>
        public DatePlace? Graduation { get; set; } = null;
    }
}
