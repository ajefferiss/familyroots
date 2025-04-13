namespace Family_Roots.DAL.Repository
{
    using Family_Roots.DAL.Exception;
    using Family_Roots.DAL.Repository.IRepository;
    using Family_Roots.DAL.Store;
    using Family_Roots.DAL.Store.Entities;
    using Microsoft.EntityFrameworkCore;

    public class PersonRepository(ApplicationDbContext db) : IPersonRepository
    {
        private readonly ApplicationDbContext _db = db;

        public async Task<Person> Create(Person person)
        {
            var addedObj = this._db.Persons.Add(person);
            await this._db.SaveChangesAsync();

            return addedObj.Entity;
        }

        public async Task<Person> Update(Person person)
        {
            var objFromDb = await this._db.Persons.FirstOrDefaultAsync(p => p.Id == person.Id);
            if (objFromDb != null)
            {
                objFromDb.GEDId = person.GEDId;
                objFromDb.Uid = person.Uid;
                objFromDb.IdNumber = person.IdNumber;
                objFromDb.FirstName = person.FirstName;
                objFromDb.LastName = person.LastName;
                objFromDb.Gender = person.Gender;
                objFromDb.Birth = person.Birth;
                objFromDb.Death = person.Death;
                objFromDb.Buried = person.Buried;
                objFromDb.Baptized = person.Baptized;
                objFromDb.Education = person.Education;
                objFromDb.Religion = person.Religion;
                objFromDb.Nationality = person.Nationality;
                objFromDb.Note = person.Note;
                objFromDb.Changed = person.Changed;
                objFromDb.Occupation = person.Occupation;
                objFromDb.Health = person.Health;
                objFromDb.Title = person.Title;
                objFromDb.LastAddress = person.LastAddress;
                objFromDb.Adopted = person.Adopted;
                objFromDb.Graduation = person.Graduation;

                this._db.Persons.Update(objFromDb);
                await this._db.SaveChangesAsync();
                return objFromDb;
            }

            throw new DALException("Person does not exist in the Data Store, cannot update.");
        }

        public async Task<int> Delete(int id)
        {
            var toRemove = await this._db.Persons.FirstOrDefaultAsync(p => p.Id == id);
            if (toRemove != null)
            {
                this._db.Persons.Remove(toRemove);
                return await this._db.SaveChangesAsync();
            }

            throw new DALException("Cannot remove person as they do not exist");
        }

        public async Task<Person> Get(int id)
        {
            var toGet = await this._db.Persons.FirstOrDefaultAsync(p => p.Id == id);
            if (toGet != null)
            {
                return toGet;
            }

            throw new DALException("Person with ID " + id + " does not exist.");
        }
    }
}
