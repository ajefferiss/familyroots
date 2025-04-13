namespace Family_Roots.DAL.Store.Entities
{
    /// <summary>
    /// Stores the different contact types <see cref="ContactType" /> for a given Address entry.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Gets or sets the database ID for the contact.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="ContactType"/> for the entry.
        /// </summary>
        public ContactType ContactType { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Address"/> for the entry.
        /// </summary>
        public Address? Address { get; set; } = null;

        /// <summary>
        /// Gets or sets the value for the <see cref="ContactType"/>, defaults to a empty string.
        /// </summary>
        public string ContactValue { get; set; } = string.Empty;
    }
}
