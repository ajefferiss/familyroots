namespace Family_Roots.DAL.Store.Entities
{
    /// <summary>
    /// Stores the adoption details for a <see cref="Person"/> if applicable.
    /// </summary>
    public class Adoption
    {
        /// <summary>
        /// Gets or sets the database ID for the entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> ID for the entry.
        /// </summary>
        public DatePlace? DatePlace { get; set; } = null;

        /// <summary>
        /// Gets or sets the type of adoption, defaults to a empty string.
        /// </summary>
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the adopting parents, defaults to empty string.
        /// </summary>
        public string AdoptingParents { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets any notes relating to the adoption, defaults to a empty string.
        /// </summary>
        public string Note { get; set; } = string.Empty;
    }
}
