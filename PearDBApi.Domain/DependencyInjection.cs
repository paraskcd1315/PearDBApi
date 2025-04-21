using Microsoft.Extensions.DependencyInjection;

namespace PearDBApi.Domain;

public static class DependencyInjection
{
  public static IServiceCollection AddDomain(this IServiceCollection services)
  {
    Console.WriteLine("info: Domain DI");
    Console.WriteLine("      Domain successfully injected");
    return services;
  }
}