namespace Family_Roots.DAL.Store.Entities
{
    /// <summary>
    /// Provides the entity type for a <see cref="DatePlaceEntity"/>.
    /// </summary>
    public enum DatePlaceEntities : int
    {
        /// <summary>
        /// Represents when a <see cref="Person"/>'s residency started.
        /// </summary>
        Residency = 0,

        /// <summary>
        /// Represents when a <see cref="Person"/> emigrated from a place.
        /// </summary
        Emigrated = 1,

        /// <summary>
        /// Represents when a <see cref="Person"/> immigrated to a place.
        /// </summary>
        Immigrated = 2,

        /// <summary>
        /// Represents when a <see cref="Person"/> became a citizen of a place.
        /// </summary>
        BecomingCitizen = 3,

        /// <summary>
        /// Represents when a <see cref="Person"/> appeared on a census for a place.
        /// </summary>
        Census = 4,

        /// <summary>
        /// Represents when a <see cref="Person"/> arrived at a destination.
        /// </summary>
        Destination = 5,
    }
}