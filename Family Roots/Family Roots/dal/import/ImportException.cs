namespace Family_Roots.DAL.Import
{
    using System;

    /// <summary>
    /// A exception to throw during import errors of genealogy resources.
    /// </summary>
    public class ImportException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportException"/> class.
        /// </summary>
        public ImportException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportException"/> class.
        /// </summary>
        /// <param name="message">The message to use in the exception.</param>
        public ImportException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ImportException"/> class.
        /// </summary>
        /// <param name="message">The message to use in the exception.</param>
        /// <param name="inner">An instance of <see cref="Exception"/> to use as the cause.</param>
        public ImportException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
