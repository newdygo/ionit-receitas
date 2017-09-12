namespace ionit.receitas.core.repositories
{
    using ionit.receitas.core.interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    /// <summary>
    /// Provides a mechanism for manage the repositories resources base.
    /// </summary>
    public abstract class RepositoryBase<TEntity> : IUnitOfWork<TEntity> where TEntity : class
    {
        #region Properties

        /// <summary>
        /// Gets the connection for use.
        /// </summary>
        protected DbContext Context { get; private set; }

        /// <summary>
        /// Gets All the entities.
        /// </summary>
        public abstract IEnumerable<TEntity> Entities { get; }

        /// <summary>
        /// Inclusão
        /// </summary>
        /// <param name="entity"></param>
        public abstract void Create(TEntity entity);

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes the RepositoryBase class.
        /// </summary>
        /// <param name="context">The connection to initialize.</param>
        internal RepositoryBase(DbContext context)
        {
            Context = context;
        }

        #endregion
    }
}
