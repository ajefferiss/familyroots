namespace Family_Roots.DAL.Store.Entities
{
    using Watson.ORM.Core;

    /// <summary>
    /// Stores the different contact types <see cref="ContactType" /> for a given Address entry.
    /// </summary>
    [Table("contact")]
    public class Contact
    {
        /// <summary>
        /// Gets or sets the database ID for the contact.
        /// </summary>
        [Column("id", true, DataTypes.Int, false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="ContactType"/> for the entry.
        /// </summary>
        [Column("type", false, DataTypes.Int, false)]
        public int Type { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Address"/> ID for the entry.
        /// </summary>
        [Column("addressId", false, DataTypes.Int, false)]
        public int AddressId { get; set; }

        /// <summary>
        /// Gets or sets the value for the <see cref="ContactType"/>, defaults to a empty string.
        /// </summary>
        [Column("value", false, DataTypes.Varchar, 2048, false)]
        public string Value { get; set; } = string.Empty;
    }
}
