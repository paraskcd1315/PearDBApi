using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PearDBApi.Application.Common.Interfaces;
using PearDBApi.Infrastructure.Persistence;
using PearDBApi.Infrastructure.Services;
using PearDBApi.Infrastructure.Utils;

namespace PearDBApi.Infrastructure;

public static class DependencyInjection
{
  public static IServiceCollection AddInfrastructure(this IServiceCollection services)
  {
    services
      .AddPersistence()
      .AddSingleton<IDateTimeProvider, DateTimeProvider>();

    Console.WriteLine("info: Infrastructure DI");
    Console.WriteLine("      Infrastructure successfully injected");
    return services;
  }

  public static IServiceCollection AddPersistence(this IServiceCollection services)
  {
    var dbConnection = EnvironmentVariables.DbConnection;

    if (dbConnection is null)
    {
      Console.WriteLine("error: Infrastructure DI");
      Console.WriteLine("       MySQL connection string missing");
      return services;
    }

    services.AddDbContext<PearDBApiDbContext>(opts =>
    {
      opts.UseMySQL(dbConnection);
      opts.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
    });

    return services;
  }
}