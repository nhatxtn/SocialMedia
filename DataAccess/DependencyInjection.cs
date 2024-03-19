using DataAccess.Core.DbContexts;
using Microsoft.Extensions.DependencyInjection;

namespace DataAccess;

public static class DependencyInjection
{
    /// <summary>
    ///     Inject the services from the DataAccess layer.
    /// </summary>
    /// <param name="services">Current Service Collection</param>
    /// <returns>
    ///     The current service collection after injecting DataAccess layer's services.
    /// </returns>
    public static IServiceCollection AddDataAccess(this IServiceCollection services)
    {

        return services;
    }
}
