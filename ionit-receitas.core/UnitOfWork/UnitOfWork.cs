namespace ionit.receitas.core.UnitOfWork
{
    using ionit.receitas.core.Context;
    using ionit.receitas.core.interfaces;
    using ionit.receitas.core.repositories;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Provides a mechanism to control the repositories acess.
    /// </summary>
    public class UnitOfWork : IUnitOfWork
    {
        #region Properties

        /// <summary>
        /// Gets the connection for use.
        /// </summary>
        protected DbContext Context { get; private set; }

        /// <summary>
        /// Gets the repository of invoices.
        /// </summary>
        public RepositoryReceita Receita => new RepositoryReceita(Context);

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the unit of work.
        /// </summary>
        /// <param name="context">The context of Receita.</param>
        public UnitOfWork(ReceitaContext context) 
        {
            Context = context;
        }

        #endregion
    }
}
