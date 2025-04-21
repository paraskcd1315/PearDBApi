using Microsoft.Extensions.DependencyInjection;

namespace PearDBApi.BackgroundServices;

public static class DependencyInjection
{
  public static IServiceCollection AddBackgroundServices(this IServiceCollection services)
  {
    Console.WriteLine("info: Background Services DI");
    Console.WriteLine("      Background Services successfully injected");
    return services;
  }
}
