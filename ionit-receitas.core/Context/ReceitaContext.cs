namespace ionit.receitas.core.Context
{
    using ionit.receitas.core.Config;
    using ionit.receitas.core.Entities;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Options;

    /// <summary>
    /// A mailgun context to access the database.
    /// </summary>
    public class ReceitaContext : DbContext
    {
        #region Properties

        /// <summary>
        /// Gets or sets the set of Receitas.
        /// </summary>
        public DbSet<Receita> Receita { get; set; }

        /// <summary>
        /// Sets the current option.
        /// </summary>
        public AppOption Option { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes the context of database.
        /// </summary>
        /// <param name="option">The option.</param>
        public ReceitaContext(IOptions<AppOption> option)
        {
            Option = option.Value;
        }

        #endregion

        #region Methods

        #region Overrides

        /// <summary>
        /// Configure the database of it's context.
        /// </summary>
        /// <param name="optionsBuilder">A builder used to create or modify options for this context.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Option.ConnectionString);

            base.OnConfiguring(optionsBuilder);
        }

        /// <summary>
        /// Configure the model of it's context database.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Receita>().HasKey(x => x.Id);
        }

        #endregion

        #endregion
    }
}
