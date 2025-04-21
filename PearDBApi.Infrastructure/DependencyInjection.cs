using Microsoft.Extensions.DependencyInjection;

namespace PearDBApi.Infrastructure;

public static class DependencyInjection
{
  public static IServiceCollection AddInfrastructure(this IServiceCollection services)
  {
    Console.WriteLine("info: Infrastructure DI");
    Console.WriteLine("      Infrastructure successfully injected");
    return services;
  }
}