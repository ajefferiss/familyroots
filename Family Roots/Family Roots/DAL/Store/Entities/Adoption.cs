namespace Family_Roots.DAL.Store.Entities
{
    using Watson.ORM.Core;

    /// <summary>
    /// Stores the adoption details for a <see cref="Person"/> if applicable.
    /// </summary>
    [Table("adoption")]
    public class Adoption
    {
        /// <summary>
        /// Gets or sets the database ID for the entry.
        /// </summary>
        [Column("id", true, DataTypes.Int, false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> ID for the entry.
        /// </summary>
        [Column("datePlace", false, DataTypes.Int, false)]
        public int DatePlace { get; set; }

        /// <summary>
        /// Gets or sets the type of adoption, defaults to a empty string.
        /// </summary>
        [Column("type", false, DataTypes.Nvarchar, 2048, false)]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the adopting parents, defaults to empty string.
        /// </summary>
        [Column("adoptingParents", false, DataTypes.Nvarchar, 2048, false)]
        public string AdoptingParents { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets any notes relating to the adoption, defaults to a empty string.
        /// </summary>
        [Column("note", false, DataTypes.Nvarchar, 2048, true)]
        public string Note { get; set; } = string.Empty;
    }
}
