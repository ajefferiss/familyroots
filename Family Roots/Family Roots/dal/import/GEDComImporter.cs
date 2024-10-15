using Family_Roots.dal.store;
using GeneGenie.Gedcom.Parser;

namespace Family_Roots.dal.import
{
    public class GEDComImporter : IFamilyHistoryImporter
    {
        private FamilyRootsStore store;

        public GEDComImporter(FamilyRootsStore dataStore)
        {
            this.store = dataStore;
        }

        public void importResource(string resource)
        {
            var gedComReader = GedcomRecordReader.CreateReader(resource);



            /**
             *                 string filename = dialog.FileName;
                var gedcomReader = GedcomRecordReader.CreateReader(filename);
                var helens = gedcomReader.Database.Individuals.FindAll(i => i.Names.First().Given.StartsWith("Helen"));

                foreach (var indi in helens)
                {
                    var family = indi.GetFamily();
                    var children = gedcomReader.Database.Individuals.FindAll(i => family.Children.Contains(i.XrefId));
                }
            */
            throw new NotImplementedException();
        }
    }
}
