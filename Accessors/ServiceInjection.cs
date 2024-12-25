using Accessors.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Accessors;

public static class ServiceInjection
{
    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>();
        services.AddTransient<IUserDataAccess, UserDataAccess>();
    }
}