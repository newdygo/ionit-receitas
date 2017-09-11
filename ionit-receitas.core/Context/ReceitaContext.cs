namespace ionit.receitas.core.Context
{
    using ionit.receitas.core.Entities;
    using Microsoft.EntityFrameworkCore;

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

        #endregion

        #region Methods

        #region Overrides

        /// <summary>
        /// Configure the database of it's context.
        /// </summary>
        /// <param name="optionsBuilder">A builder used to create or modify options for this context.</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(optionsBuilder.Options. Tenant.ConnectionString);

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
