namespace Family_Roots.DAL.Store.Entities
{
    /// <summary>
    /// Stores the different data place entity types <see cref="DatePlaceEntities" /> for a given <see cref="Person"/>.
    /// </summary>
    public class DatePlaceEntity
    {
        /// <summary>
        /// Gets or sets the database ID for the entry.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> ID for the entity.
        /// </summary>
        public DatePlace? DatePlace { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Person"/> ID for the entity.
        /// </summary>
        public Person? Person { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DatePlaceEntities"/> for the entity.
        /// </summary>
        public DatePlaceEntities? EntityType { get; set; }
    }
}
