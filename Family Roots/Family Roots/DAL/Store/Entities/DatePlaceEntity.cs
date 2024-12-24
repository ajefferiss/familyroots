namespace Family_Roots.DAL.Store.Entities
{
    using Watson.ORM.Core;

    /// <summary>
    /// Stores the different data place entity types <see cref="DatePlaceEntities" /> for a given <see cref="Person"/>.
    /// </summary>
    [Table("datePlaceEntity")]
    public class DatePlaceEntity
    {
        /// <summary>
        /// Gets or sets the database ID for the entry.
        /// </summary>
        [Column("id", true, DataTypes.Int, false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> ID for the entity.
        /// </summary>
        [Column("datePlace", false, DataTypes.Int, false)]
        public int DatePlace { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Person"/> ID for the entity.
        /// </summary>
        [Column("person", false, DataTypes.Int, false)]
        public int Person { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="DatePlaceEntities"/> for the entity.
        /// </summary>
        [Column("type", false, DataTypes.Int, false)]
        public int Type { get; set; }
    }
}
