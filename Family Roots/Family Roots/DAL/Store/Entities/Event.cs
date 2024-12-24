namespace Family_Roots.DAL.Store.Entities
{
    using Watson.ORM.Core;

    /// <summary>
    /// Table to represent a given Event for a <see cref="Person"/>.
    /// Events are grouped by the Event column, with multiple <see cref="DatePlace"/> references allowed under a given Event.
    /// </summary>
    [Table("event")]
    public class Event
    {
        /// <summary>
        /// Gets or sets the database ID for the event.
        /// </summary>
        [Column(true, DataTypes.Int, false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the event.
        /// </summary>
        [Column("eventName", false, DataTypes.Nvarchar, 2048, false)]
        public string EventName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the <see cref="DatePlace"/> ID for the event.
        /// </summary>
        [Column("datePlace", false, DataTypes.Int, false)]
        public int DatePlace { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Person"/> ID for the event.
        /// </summary>
        [Column("person", false, DataTypes.Int, false)]
        public int Person { get; set; }
    }
}
