using System.Linq.Expressions;

namespace WebApp501.Infrastructure.Data.Common
{
    /// <summary>
    /// Abstraction of repository access methods.
    /// </summary>
    public interface IRepository : IDisposable
    {
        /// <summary>
        /// All records in a table.
        /// </summary>
        /// <returns>Queryable expression tree.</returns>
        IQueryable<T> All<T>()
            where T : class;

        /// <summary>
        /// All records in a table.
        /// </summary>
        /// <returns>Queryable expression tree.</returns>
        IQueryable<T> All<T>(Expression<Func<T, bool>> search)
            where T : class;

        /// <summary>
        /// The result collection won't be tracked by the context.
        /// </summary>
        /// <returns>Expression tree.</returns>
        IQueryable<T> AllReadonly<T>()
            where T : class;

        /// <summary>
        /// The result collection won't be tracked by the context.
        /// </summary>
        /// <returns>Expression tree.</returns>
        IQueryable<T> AllReadonly<T>(Expression<Func<T, bool>> search)
            where T : class;

        /// <summary>
        /// Gets specific record from database by primary key.
        /// </summary>
        /// <param name="id">Record identificator.</param>
        /// <returns>Single record.</returns>
        Task<T> GetByIdAsync<T>(object id)
            where T : class;

        /// <summary>
        /// Gets an array of records from database by primary keys.
        /// </summary>
        /// <typeparam name="T">Type of the database model.</typeparam>
        /// <param name="id">Record identificators.</param>
        /// <returns>Single record.</returns>
        Task<T> GetByIdsAsync<T>(object[] id)
            where T : class;

        /// <summary>
        /// Adds entity to the database.
        /// </summary>
        /// <param name="entity">Entity to add.</param>
        Task AddAsync<T>(T entity)
            where T : class;

        /// <summary>
        /// Adds collection of entities to the database.
        /// </summary>
        /// <param name="entities">Enumerable list of entities.</param>
        Task AddRangeAsync<T>(IEnumerable<T> entities)
            where T : class;

        /// <summary>
        /// Updates a record in database.
        /// </summary>
        /// <param name="entity">Entity for record to be updated.</param>
        void Update<T>(T entity)
            where T : class;

        /// <summary>
        /// Updates set of records in the database.
        /// </summary>
        /// <param name="entities">Enumerable collection of entities to be updated.</param>
        void UpdateRange<T>(IEnumerable<T> entities)
            where T : class;

        /// <summary>
        /// Deletes a record from database.
        /// </summary>
        /// <param name="id">Identificator of record to be deleted.</param>
        Task DeleteAsync<T>(object id)
            where T : class;

        /// <summary>
        /// Deletes a record from database.
        /// </summary>
        /// <param name="entity">Entity representing record to be deleted.</param>
        void Delete<T>(T entity)
            where T : class;

        /// <summary>
        /// Deletes set of records from database.
        /// </summary>
        /// <typeparam name="T">Type of the database model.</typeparam>
        /// <param name="entities">Collection of entities representing records to be deleted.</param>
        void DeleteRange<T>(IEnumerable<T> entities)
            where T : class;

        /// <summary>
        /// Deletes set of records form database (with a "Where" clause).
        /// </summary>
        /// <typeparam name="T">Type of the database model.</typeparam>
        /// <param name="deleteWhereClause">Expression to be used when deleting entities.</param>
        void DeleteRange<T>(Expression<Func<T, bool>> deleteWhereClause)
            where T : class;

        /// <summary>
        /// Detaches given entity from the context.
        /// </summary>
        /// <param name="entity">Entity to be detached.</param>
        void Detach<T>(T entity)
            where T : class;

        /// <summary>
        /// Saves all made changes in transaction.
        /// </summary>
        /// <returns>Error code.</returns>
        Task<int> SaveChangesAsync();
    }
}