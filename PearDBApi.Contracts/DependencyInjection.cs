using Microsoft.Extensions.DependencyInjection;

namespace PearDBApi.Contracts;

public static class DependencyInjection
{
  public static IServiceCollection AddContracts(this IServiceCollection services)
  {
    Console.WriteLine("info: Contracts DI");
    Console.WriteLine("      Contracts successfully injected");
    return services;
  }
}