using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace WebApp501.Infrastructure.Data.Common
{
    /// <summary>
    /// Implementation of repository access methods for Relational Database Engine.
    /// </summary>
    public class Repository : IRepository
    {
        /// <summary>
        /// Entity framework DB context holding connection information, properties and tracking entity states.
        /// </summary>
        protected DbContext Context { get; set; }

        /// <summary>
        /// Representation of table in database.
        /// </summary>
        protected DbSet<T> DbSet<T>()
            where T : class
        {
            return this.Context.Set<T>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository"/> class.
        /// </summary>
        /// <param name="context">Main class of the database.</param>
        public Repository(WebAppDbContext context)
        {
            Context = context;
        }

        /// <summary>
        /// Adds entity to the database.
        /// </summary>
        /// <param name="entity">Entity to add.</param>
        public async Task AddAsync<T>(T entity)
            where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        /// <summary>
        /// Adds collection of entities to the database.
        /// </summary>
        /// <param name="entities">Enumerable list of entities.</param>
        public async Task AddRangeAsync<T>(IEnumerable<T> entities)
            where T : class
        {
            await DbSet<T>().AddRangeAsync(entities);
        }

        /// <summary>
        /// All records in a table.
        /// </summary>
        /// <returns>Queryable expression tree.</returns>
        public IQueryable<T> All<T>()
            where T : class
        {
            return DbSet<T>().AsQueryable();
        }

        /// <summary>
        /// All records in a table.
        /// </summary>
        /// <param name="search">Search expression to be used on the database.</param>
        /// <returns>Queryable expression tree.</returns>
        public IQueryable<T> All<T>(Expression<Func<T, bool>> search)
            where T : class
        {
            return this.DbSet<T>().Where(search);
        }

        /// <summary>
        /// The result collection won't be tracked by the context.
        /// </summary>
        /// <returns>Expression tree.</returns>
        public IQueryable<T> AllReadonly<T>()
            where T : class
        {
            return this.DbSet<T>()
                .AsNoTracking();
        }

        /// <summary>
        /// The result collection won't be tracked by the context (uses a search expression).
        /// </summary>
        /// <param name="search">Search expression to be used on the database.</param>
        /// <returns>Expression tree.</returns>
        public IQueryable<T> AllReadonly<T>(Expression<Func<T, bool>> search)
            where T : class
        {
            return this.DbSet<T>()
                .Where(search)
                .AsNoTracking();
        }

        /// <summary>
        /// Deletes a record from database.
        /// </summary>
        /// <param name="id">Identificator of record to be deleted.</param>
        public async Task DeleteAsync<T>(object id)
            where T : class
        {
            T entity = await GetByIdAsync<T>(id);

            Delete<T>(entity);
        }

        /// <summary>
        /// Deletes a record from database.
        /// </summary>
        /// <param name="entity">Entity representing record to be deleted.</param>
        public void Delete<T>(T entity)
            where T : class
        {
            EntityEntry entry = this.Context.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                this.DbSet<T>().Attach(entity);
            }

            entry.State = EntityState.Deleted;
        }

        /// <summary>
        /// Detaches given entity from the context.
        /// </summary>
        /// <param name="entity">Entity to be detached.</param>
        public void Detach<T>(T entity)
            where T : class
        {
            EntityEntry entry = this.Context.Entry(entity);

            entry.State = EntityState.Detached;
        }

        /// <summary>
        /// Disposing the context when it is not needed.
        /// Don't have to call this method explicitely
        /// Leave it to the IoC container
        /// </summary>
        public void Dispose()
        {
            this.Context.Dispose();
        }

        /// <summary>
        /// Gets specific record from database by primary key.
        /// </summary>
        /// <param name="id">Record identificator.</param>
        /// <returns>Single record.</returns>
        public async Task<T> GetByIdAsync<T>(object id)
            where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }

        /// <summary>
        /// Gets specific record from database by primary keys.
        /// </summary>
        /// <param name="id">Array of ids to be used.</param>
        /// <returns>Single record.</returns>
        public async Task<T> GetByIdsAsync<T>(object[] id)
            where T : class
        {
            return await DbSet<T>().FindAsync(id);
        }

        /// <summary>
        /// Saves all made changes in transaction.
        /// </summary>
        /// <returns>Error code.</returns>
        public async Task<int> SaveChangesAsync()
        {
            return await this.Context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates a record in database.
        /// </summary>
        /// <param name="entity">Entity for record to be updated.</param>
        public void Update<T>(T entity)
            where T : class
        {
            this.DbSet<T>().Update(entity);
        }

        /// <summary>
        /// Updates set of records in the database.
        /// </summary>
        /// <param name="entities">Enumerable collection of entities to be updated.</param>
        public void UpdateRange<T>(IEnumerable<T> entities)
            where T : class
        {
            this.DbSet<T>().UpdateRange(entities);
        }

        /// <summary>
        /// Deletes set of records from the database.
        /// </summary>
        /// <param name="entities">Collection of entities representing records to be deleted.</param>
        public void DeleteRange<T>(IEnumerable<T> entities)
            where T : class
        {
            this.DbSet<T>().RemoveRange(entities);
        }

        /// <summary>
        /// Deletes set of records from the database (with a "Where" clause).
        /// </summary>
        /// <param name="deleteWhereClause">Expression to be used when deleting entities.</param>
        public void DeleteRange<T>(Expression<Func<T, bool>> deleteWhereClause)
            where T : class
        {
            var entities = All<T>(deleteWhereClause);
            DeleteRange(entities);
        }
    }
}