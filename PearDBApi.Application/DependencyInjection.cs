using Microsoft.Extensions.DependencyInjection;

namespace PearDBApi.Application;

public static class DependencyInjection
{
  public static IServiceCollection AddApplication(this IServiceCollection services)
  {
    Console.WriteLine("info: Application DI");
    Console.WriteLine("      Application successfully injected");
    return services;
  }
}
