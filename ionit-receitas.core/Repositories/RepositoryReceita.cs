namespace ionit.receitas.core.repositories
{
    using ionit.receitas.core.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;

    /// <summary>
    /// Provides a repository of Receitas.
    /// </summary>
    public class RepositoryReceita : RepositoryBase<Receita>
    {
        #region Properties

        /// <summary>
        /// Gets All the entities.
        /// </summary>
        public override IEnumerable<Receita> Entities
        {
            get
            {
                return Context.Set<Receita>();
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes the repository of invoices.
        /// </summary>
        /// <param name="context">Represents the context.</param>
        public RepositoryReceita(DbContext context) : base(context)
        {
        }

        #endregion
    }
}
