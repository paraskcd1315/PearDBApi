using System.Text.Json.Serialization;

namespace PearDBApi.Main;

public static class DependencyInjection
{
  public static IServiceCollection AddPresentation(this IServiceCollection services, ConfigurationManager configuration)
  {
    services.AddCors(options =>
    {
      options.AddDefaultPolicy(builder =>
      {
        builder.AllowAnyHeader();
        builder.AllowAnyMethod();
        builder.AllowAnyOrigin();
        builder.SetIsOriginAllowedToAllowWildcardSubdomains();
      });
    });

    services
      .AddControllers()
      .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()));

    services.AddRouting(opts => opts.LowercaseUrls = true);

    services
      .AddEndpointsApiExplorer()
      .AddSwaggerGen(c =>
      {
        c.SwaggerDoc("v1", new() { Title = "PearDB API", Version = "v1" });
        c.EnableAnnotations();
      });

    Console.WriteLine("info: Main DI");
    Console.WriteLine("      Api successfully injected");
    return services;
  }
}