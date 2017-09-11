namespace ionit.receitas.core.Context
{
    using ionit.receitas.core.Config;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Infrastructure;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Options;

    public class DesignTimeContext : IDbContextFactory<ReceitaContext>
    {
        public ReceitaContext Create(DbContextFactoryOptions options)
        {
            var builder = new DbContextOptionsBuilder<ReceitaContext>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(options.ApplicationBasePath)
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              .Build();

            var appOption = new AppOption();
            configuration.GetSection("AppOptions").Bind(appOption);

            return new ReceitaContext(Options.Create(appOption));
        }
    }
}
