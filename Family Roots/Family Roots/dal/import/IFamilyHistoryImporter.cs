namespace Family_Roots.DAL.Import
{
    /// <summary>
    /// Provides an interface for importing genealogy resources into Family Roots.
    /// </summary>
    public interface IFamilyHistoryImporter
    {
        /// <summary>
        /// Import a genealogy resource into the Family Roots data store.
        /// </summary>
        /// <param name="resource">The path to the resource to import.</param>
        /// <exception cref="ImportException">Thrown when <paramref name="resource"> is empty or when import fails</exception>
        void ImportResource(string resource);
    }
}
