namespace Family_Roots.DAL.Store.Entities
{
    /// <summary>
    /// Contains details for a given GEDCom DatePlace, these are used to store details about a <see cref="Person"/> such as DOB, Death etc.
    /// </summary>
    public class DatePlace
    {
        /// <summary>
        /// Gets or sets database ID for the entity.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the date for the entity. Note, this is in a variety of formats from a date time to "Around 1800", defaults to a empty string.
        /// </summary>
        public string Date { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the place for the entity, defaults to a empty string.
        /// </summary>
        public string Place { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the latitude for the place, defaults to a empty string.
        /// </summary>
        public string Latitude { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the longitude for the place, defaults to a empty string.
        /// </summary>
        public string Longitude { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets any notes for the DatePlace entry, defaults to a empty string.
        /// </summary>
        public string Note { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the description for a DatePlace entry, defaults to a empty string.
        /// </summary>
        public string Description { get; set; } = string.Empty;
    }
}
