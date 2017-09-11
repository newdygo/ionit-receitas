namespace ionit.receitas.core.Context
{
    using ionit.receitas.core.Config;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.Options;
    using System;

    public class DesignTimeContext : IDesignTimeDbContextFactory<ReceitaContext>
    {
        public ReceitaContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ReceitaContext>();

            IConfigurationRoot configuration = new ConfigurationBuilder()
              .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
              .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
              .Build();
            
            var appOption = new AppOption();
            configuration.GetSection("AppOptions").Bind(appOption);
            
            return new ReceitaContext(Options.Create(appOption));
        }
    }
}
