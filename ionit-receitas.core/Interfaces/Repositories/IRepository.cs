namespace ionit.receitas.core.interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Provides a generic repository.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity> where TEntity : class
    {
        #region Properties

        /// <summary>
        /// Gets All the entities.
        /// </summary>
        IEnumerable<TEntity> Entities { get; }

        #endregion
    }
}
