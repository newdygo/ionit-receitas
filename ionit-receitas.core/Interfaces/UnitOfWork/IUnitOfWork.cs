namespace ionit.receitas.core.interfaces
{
    using ionit.receitas.core.repositories;

    /// <summary>
    /// Provides a mechanism to acess all the repositories.
    /// </summary>
    public interface IUnitOfWork
    {
        #region Methods

        /// <summary>
        /// Gets the Repository of Receitas.
        /// </summary>
        RepositoryReceita Receita { get; }

        #endregion
    }
}
