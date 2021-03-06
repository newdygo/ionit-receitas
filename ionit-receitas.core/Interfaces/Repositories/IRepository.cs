﻿namespace ionit.receitas.core.interfaces
{
    using System.Collections.Generic;

    /// <summary>
    /// Provides a generic repository.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IUnitOfWork<TEntity> where TEntity : class
    {
        #region Properties

        /// <summary>
        /// Gets All the entities.
        /// </summary>
        IEnumerable<TEntity> Entities { get; }

        /// <summary>
        /// Inclusão
        /// </summary>
        /// <param name="entity"></param>
        void Create(TEntity entity);

        IEnumerable<TEntity> List();
        #endregion
    }
}
