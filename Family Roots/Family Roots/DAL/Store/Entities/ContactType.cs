namespace Family_Roots.DAL.Store.Entities
{
    /// <summary>
    /// Provides the contact type for an <see cref="Address"/> entity.
    /// </summary>
    public enum ContactType : int
    {
        /// <summary>
        /// Represents a phone number.
        /// </summary>
        Phone = 0,

        /// <summary>
        /// Represents a fax number.
        /// </summary>
        Fax = 1,

        /// <summary>
        /// Represents a email address.
        /// </summary>
        Email = 2,

        /// <summary>
        /// Represents a website URL.
        /// </summary>
        Web = 3,
    }
}
