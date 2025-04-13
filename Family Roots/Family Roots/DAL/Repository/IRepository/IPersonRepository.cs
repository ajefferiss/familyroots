namespace Family_Roots.DAL.Repository.IRepository
{
    using Family_Roots.DAL.Exception;
    using Family_Roots.DAL.Store.Entities;

    /// <summary>
    /// Interface defining Data Store access for <see cref="Person"/>.
    /// </summary>
    public interface IPersonRepository
    {
        /// <summary>
        /// Creates an instance of a <see cref="Person"/> in the Data Store.
        /// </summary>
        /// <param name="person">The <see cref="Person"/> to store.</param>
        /// <returns>The <see cref="Person"/> stored in the Data Store.</returns>
        public Task<Person> Create(Person person);

        /// <summary>
        /// Updates an instance of a <see cref="Person"/> in the Data Store.
        /// </summary>
        /// <param name="person">The updated <see cref="Person"/> to store.</param>
        /// <returns>The <see cref="Person"/> to update.</returns>
        /// <exception cref="DALExcpetion">Thrown if the person to update is invalid, or cannot be updated.</exception>
        public Task<Person> Update(Person person);

        /// <summary>
        /// Deletes a specified <see cref="Person"/> by Data Store ID.
        /// </summary>
        /// <param name="id">The ID of the <see cref="Person"/> to remove.</param>
        /// <returns>The ID of the person removed.</returns>
        /// <exception cref="DALException">Thrown if the person to be deleted does not exist.</exception>
        public Task<int> Delete(int id);

        /// <summary>
        /// Gets a specific <see cref="Person"/> from the Data Store.
        /// </summary>
        /// <param name="id">The ID of the <see cref="Person"/> to retrieve.</param>
        /// <returns>The person retrieved.</returns>
        /// <exception cref="DALException">Thrown if the person does not exist.</exception>
        public Task<Person> Get(int id);
    }
}
