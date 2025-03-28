namespace Family_Roots.DAL.Store.Entities
{
    /// <summary>
    /// Stores the address details for a <see cref="Person"/>.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the Database ID for the entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the street of the address, defaults to a empty string.
        /// </summary>
        public string Street { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the town or city for the address, defaults to a empty string.
        /// </summary>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the state/county for the address, defaults to a empty String.
        /// </summary>
        public string State { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the zip/postal code for the address, defaults to a empty string.
        /// </summary>
        public string ZipCode { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the country for the address, defaults to a empty string.
        /// </summary>
        public string Country { get; set; } = string.Empty;
    }
}
