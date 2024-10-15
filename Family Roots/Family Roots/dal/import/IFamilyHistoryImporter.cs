namespace Family_Roots.dal.import
{
    interface IFamilyHistoryImporter
    {
        // <summary>
        // Import a genealogy resource into the Family Roots data store
        // </summary>
        // <exception cref="ImportException">Thrown when <paramref name="resource"> is empty or when import fails</exception>
        void importResource(String resource);
    }
}
