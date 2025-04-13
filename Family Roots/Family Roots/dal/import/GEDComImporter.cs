namespace Family_Roots.DAL.Import
{
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Family_Roots.DAL.Repository;
    using Family_Roots.DAL.Store;
    using Family_Roots.DAL.Store.Entities;
    using GedcomParser.Services;
    using Microsoft.EntityFrameworkCore;

    public class GEDComImporter : IFamilyHistoryImporter
    {
        private readonly ApplicationDbContext store;
        private static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        private PersonRepository personRepository;

        public GEDComImporter(ApplicationDbContext dataStore)
        {
            this.store = dataStore;
            this.personRepository = new PersonRepository(this.store);
        }

        public async Task ImportResource(string resource)
        {
            Logger.Info("Importing GEDCom resource from {}", resource);
            var detailsToImport = new List<ImportPerson>();
            var gedComResult = FileParser.ParseLines(File.ReadLines(resource));

            foreach (var indi in gedComResult.Persons)
            {
                if (indi == null)
                {
                    Logger.Info("Not importing null person");
                    continue;
                }


                try
                {

                    var personToAdd = ConvertToPerson(indi);
                    var personAdded = await this.personRepository.Create(personToAdd);
                } 
                catch (ArgumentNullException ane)
                {
                    Logger.Error(ane, "Error converting person: {0}", indi);
                }

                    //this.store.Add(personToAdd);
                    //await this.store.SaveChangesAsync();

                    //var contacts = CreateContactDetails(indi.Address, personToAdd.LastAddress);
                    //var events = CreateEvents(indi.Events, personToAdd);

                    //this.store.Add(contacts);
                    //this.store.Add(events);
                    //await this.store.SaveChangesAsync();
          
            }
        }

        private static Person ConvertToPerson(GedcomParser.Entities.Person individual)
        {
            return new Person
            {
                GEDId = individual.Id,
                Uid = GetStringOrDefault(individual.Uid),
                IdNumber = GetStringOrDefault(individual.IdNumber),
                FirstName = GetStringOrDefault(individual.FirstName),
                LastName = GetStringOrDefault(individual.LastName),
                Title = GetStringOrDefault(individual.Title),
                Gender = GetStringOrDefault(individual.Gender),
                Birth = CreateDatePlace(individual.Birth),
                Death = CreateDatePlace(individual.Death),
                Buried = CreateDatePlace(individual.Buried),
                Baptized = CreateDatePlace(individual.Baptized),
                Education = GetStringOrDefault(individual.Education),
                Religion = GetStringOrDefault(individual.Religion),
                Nationality = GetStringOrDefault(individual.Nationality),
                Note = GetStringOrDefault(individual.Note),
                Changed = GetStringOrDefault(individual.Changed),
                Occupation = GetStringOrDefault(individual.Occupation),
                Health = GetStringOrDefault(individual.Health),
                LastAddress = CreateAddress(individual.Address),
                Adopted = CreateAdopted(individual.Adoption),
                Graduation = CreateDatePlace(individual.Graduation),
            };
        }

        private static DatePlace? CreateDatePlace(GedcomParser.Entities.DatePlace date)
        {
            if (date == null)
            {
                return null;
            }

            return new DatePlace
            {
                Date = GetStringOrDefault(date.Date),
                Place = GetStringOrDefault(date.Place),
                Latitude = GetStringOrDefault(date.Latitude),
                Longitude = GetStringOrDefault(date.Longitude),
                Note = GetStringOrDefault(date.Note),
                Description = GetStringOrDefault(date.Description),
            };
        }

        private static Address? CreateAddress(GedcomParser.Entities.Address address)
        {
            if (address == null)
            {
                return null;
            }

            return new Address
            {
                Street = GetStringOrDefault(address.Street),
                City = GetStringOrDefault(address.City),
                State = GetStringOrDefault(address.State),
                ZipCode = GetStringOrDefault(address.ZipCode),
                Country = GetStringOrDefault(address.Country),
            };
        }

        private static Adoption? CreateAdopted(GedcomParser.Entities.Adoption adoption)
        {
            if (adoption == null)
            {
                return null;
            }

            return new Adoption
            {
                DatePlace = CreateDatePlace(adoption.DatePlace),
                Type = adoption.Type,
                AdoptingParents = adoption.AdoptingParents,
                Note = GetStringOrDefault(adoption.Note),
            };
        }

        private static List<Contact> CreateContactDetails(GedcomParser.Entities.Address contact, Address? address)
        {
            var contactDetails = new List<Contact>();

            contactDetails.AddRange(CreateContactDetail(contact.Phone, ContactType.Phone, address));
            contactDetails.AddRange(CreateContactDetail(contact.Fax, ContactType.Fax, address));
            contactDetails.AddRange(CreateContactDetail(contact.Email, ContactType.Email, address));
            contactDetails.AddRange(CreateContactDetail(contact.Web, ContactType.Web, address));

            return contactDetails;
        }

        private static List<Contact> CreateContactDetail(List<string> contacts, ContactType contactType, Address? address = null)
        {
            return contacts.Where(c => !string.IsNullOrWhiteSpace(c)).Select(c => new Contact { ContactType = contactType, Address = address, ContactValue = c }).ToList();
        }

        private static List<Event> CreateEvents(Dictionary<string, List<GedcomParser.Entities.DatePlace>> personsEvents, Person person)
        {
            var events = new List<Event>();

            foreach (var personEvent in personsEvents)
            {
                events.AddRange(personEvent.Value.Select(d => new Event { EventName = personEvent.Key, DatePlace = CreateDatePlace(d), Person = person }).ToList());
            }

            return events;
        }

        private static string GetStringOrDefault(string? value)
        {
            return string.IsNullOrEmpty(value) ? string.Empty : value;
        }
    }
}
