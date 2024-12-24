namespace Family_Roots.DAL.Import
{
    using Family_Roots.DAL.Store;
    using Family_Roots.DAL.Store.Entities;
    using GedcomParser.Services;
    using System.IO;

    public class GEDComImporter : IFamilyHistoryImporter
    {
        private FamilyRootsStore store;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        public GEDComImporter(FamilyRootsStore dataStore)
        {
            this.store = dataStore;
        }

        public void ImportResource(string resource)
        {
            Logger.Info("Importing GEDCom resource from {}", resource);
            var detailsToImport = new List<ImportPerson>();
            var gedComResult = FileParser.ParseLines(File.ReadLines(resource));

            foreach (var indi in gedComResult.Persons)
            {
                // Person dates



                //List<LocationInfo> locations = convertToLocations(indi);
                //List<Destination> destinations = convertToDestinations();
                //List<Events> events = convertToEvents(indi.Events);
                //List<EventDates> eventDates = convertToEventDates(indi.Events);

                if (indi == null)
                {
                    Logger.Info("Not importing null person");
                    continue;
                }

                detailsToImport.Add(
                    new ImportPerson
                    {
                        /***
                         
        
        
        
        public List<AdoptedPerson> AdoptedPersons { get; set; } = new List<AdoptedPerson>();
        public List<Adoption> Adoptions { get; set; } = new List<Adoption>();
        public List<Events> Events { get; set; } = new List<Events>();
        public List<EventDates> EventDates { get; set; } = new List<EventDates>();
        
        
                         */

                        Person = convertToPerson(indi),
                        Birth = convertToDatePlace(indi.Birth),
                        Death = convertToDatePlace(indi.Death),
                        Address = convertToAddress(indi.Address),
                        //Census = convertToDatePlaceList(indi.Census),
                        //Destination = convertToDatePlaceList(indi.Destination),
                        //Events = convertToEvents(indi.Events),
                        //EventDates = convertToEventDates(indi.Events),

                    }
                );
            }

            // Save details to DB
        }

        private Person convertToPerson(GedcomParser.Entities.Person individual)
        {
            return new Person
            {
                GEDId = individual.Id,
                Uid = individual.Uid,
                IdNumber = individual.IdNumber,
                FirstName = individual.FirstName,
                LastName = individual.LastName,
                Title = individual.Title,
                Gender = individual.Gender,
                Education = individual.Education,
                Religion = individual.Religion,
                Nationality = individual.Nationality,
                Note = individual.Note,
                Occupation = individual.Occupation,
                Health = individual.Health,
            };
        }

        private DatePlace? convertToDatePlace(GedcomParser.Entities.DatePlace date)
        {
            if (date == null) { return null; }

            return new DatePlace
            {
                Date = (date.Date != null) ? date.Date : String.Empty,
                Place = (date.Place != null) ? date.Place : String.Empty,
                Latitude = (date.Place != null) ? date.Place : String.Empty,
                Longitude = (date.Place != null) ? date.Place : String.Empty,
                Note = date.Note
            };
        }

        private Address? convertToAddress(GedcomParser.Entities.Address address)
        {
            if (address == null) { return null; }

            return null;
            /*
            return new Address
            {
                AddressLine1 = address.Street,
                City = address.City,
                State = address.State,
                PostalCode = address.ZipCode,
                Country = address.Country,
                Phone = address.Phone.FirstOrDefault(s => !string.IsNullOrEmpty(s)) ?? "",
                Fax = address.Fax.FirstOrDefault(s => !string.IsNullOrEmpty(s)) ?? "",
                Email = address.Email.FirstOrDefault(s => !string.IsNullOrEmpty(s)) ?? "",
                Web = address.Web.FirstOrDefault(s => !string.IsNullOrEmpty(s)) ?? ""
            };
            */
        }

        private List<DatePlace> convertToDatePlaceList(List<GedcomParser.Entities.DatePlace> censusList)
        {
            List<DatePlace> census = new List<DatePlace>();

            foreach (var c in censusList)
            {
                var datePlace = convertToDatePlace(c);
                if (datePlace == null)
                {
                    Logger.Debug("Not adding a null DatePlace to list");
                    continue;
                }
                census.Add(datePlace);
            }

            return census;
        }
    }
}
