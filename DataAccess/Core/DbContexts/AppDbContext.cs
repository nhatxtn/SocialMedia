using DataAccess.Core.Configurations;
using DataAccess.Core.DataSeedings;
using DataAccess.Core.Entities;
using DataAccess.ExtensionMethods;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace DataAccess.Core.DbContexts;

public class AppDbContext :
    IdentityDbContext<UserEntity, RoleEntity, Guid>
{
    //public AppDbContext(DbContextOptions<AppDbContext> options)
    //    : base(options)
    //{
    //}

    public AppDbContext() : base()
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Below comment for migrations purpose.
        var connectionString = "Data Source=localhost;Initial Catalog=SWD392_SocialMedia_DB;User ID=sa;Password=123123;Trust Server Certificate=True";
        optionsBuilder.UseSqlServer(connectionString);
        optionsBuilder.UseLoggerFactory(GetLoggerFactory());
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        // IdentityServer default configuration.
        base.OnModelCreating(builder);

        RemoveAspNetPrefixInIdentityTable(builder);

        // Entities configuration.
        ApplyEntityConfiguration(builder);
    }

    private void RemoveAspNetPrefixInIdentityTable(ModelBuilder builder)
    {
        const string AspNetPrefix = "AspNet";
        int index = AspNetPrefix.Length;

        builder.Model
            .GetEntityTypes()
            .ForEach(action: entityType =>
            {
                var tableName = entityType.GetTableName();

                if (tableName.StartsWith(value: AspNetPrefix))
                {
                    entityType.SetTableName(name: $"{tableName[index..]}");
                }
            });
    }

    private void ApplyEntityConfiguration(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }

    private static ILoggerFactory GetLoggerFactory()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection.AddLogging(builder =>
                builder.AddConsole()
                        .AddFilter(DbLoggerCategory.Database.Command.Name,
                                LogLevel.Information));

        return serviceCollection.BuildServiceProvider()
                .GetService<ILoggerFactory>();
    }
}
