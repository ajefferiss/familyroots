namespace Family_Roots.DAL.Store.Entities
{
    using Watson.ORM.Core;

    /// <summary>
    /// Table to represent a GEDCom parsed person.
    /// </summary>
    [Table("person")]
    public class Person
    {
        /// <summary>
        /// Gets or sets the database ID.
        /// </summary>
        [Column("id", true, DataTypes.Int, false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the GEDCom ID.
        /// </summary>
        [Column("gedId", false, DataTypes.Nvarchar, 2048, false)]
        public string GEDId { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the Uid for a Person, defaults to a empty string.
        /// </summary>
        [Column("uid", false, DataTypes.Nvarchar, 2048, false)]
        public string Uid { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the ID Number for a person, defaults to a empty string.
        /// </summary>
        [Column("idNumber", false, DataTypes.Nvarchar, 2048, false)]
        public string IdNumber { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the persons first name, defaults to a empty string.
        /// </summary>
        [Column("firstName", false, DataTypes.Nvarchar, 2048, false)]
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the persons last name, defaults to a empty string.
        /// </summary>
        [Column("lastName", false, DataTypes.Nvarchar, 2048, false)]
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets gender, defaults to a empty string.
        /// </summary>
        [Column("gender", false, DataTypes.Nvarchar, 2048, false)]
        public string Gender { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> id for the persons birth, defaults to null.
        /// </summary>
        [Column("birthId", false, DataTypes.Int, true)]
        public int? Birth { get; set; } = null;

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> id for persons death, defaults to null.
        /// </summary>
        [Column("deathId", false, DataTypes.Int, true)]
        public int? Death { get; set; } = null;

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> id for the date a person was buried, defaults to null.
        /// </summary>
        [Column("buriedId", false, DataTypes.Int, true)]
        public int? Buried { get; set; } = null;

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> id for the date a person was baptized, defaults to null.
        /// </summary>
        [Column("baptizedId", false, DataTypes.Int, true)]
        public int? Baptized { get; set; } = null;

        /// <summary>
        /// Gets or sets the persons education, defaults to a empty string.
        /// </summary>
        [Column("education", false, DataTypes.Nvarchar, 2048, false)]
        public string Education { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the persons religion, defaults to a empty string.
        /// </summary>
        [Column("religion", false, DataTypes.Nvarchar, 2048, false)]
        public string Religion { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the nationality for a person, defaults to a empty string.
        /// </summary>
        [Column("nationality", false, DataTypes.Nvarchar, 2048, false)]
        public string Nationality { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets any notes for the person, defaults to a empty string.
        /// </summary>
        [Column("note", false, DataTypes.Nvarchar, 2048, false)]
        public string Note { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets changed flag for a person, defaults to a empty string.
        /// </summary>
        [Column("changed", false, DataTypes.Nvarchar, 2048, false)]
        public string Changed { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the occupation for a person, defaults to a empty string.
        /// </summary>
        [Column("occupation", false, DataTypes.Nvarchar, 2048, false)]
        public string Occupation { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets details of a persons health, defaults to a empty string.
        /// </summary>
        [Column("health", false, DataTypes.Nvarchar, 2048, false)]
        public string Health { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets title (Mr, Miss, Dr, etc) for the person, defaults to a empty string.
        /// </summary>
        [Column("title", false, DataTypes.Nvarchar, 2048, false)]
        public string Title { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the <see cref="Address"/> ID for the person, defaults to null.
        /// </summary>
        [Column("addressId", false, DataTypes.Int, true)]
        public int? Address { get; set; } = null;

        /// <summary>
        /// Gets or sets the <see cref="Adoption"/> ID for the person, defaults to null.
        /// </summary>
        [Column("adoption", false, DataTypes.Int, true)]
        public int? Adoption { get; set; } = null;

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> ID for the graduation date, defaults to null.
        /// </summary>
        [Column("graduation", false, DataTypes.Int, true)]
        public int? Graduation { get; set; } = null;
    }
}
