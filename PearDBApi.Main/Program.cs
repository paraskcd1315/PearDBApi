using Microsoft.AspNetCore.Http.Features;
using PearDBApi.Application;
using PearDBApi.BackgroundServices;
using PearDBApi.Infrastructure;
using PearDBApi.Main;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services
  .AddPresentation(builder.Configuration)
  .AddApplication()
  .AddInfrastructure()
  .AddBackgroundServices();

var app = builder.Build();

app
  .UseSwagger()
  .UseSwaggerUI(c =>
  {
    c.ConfigObject.AdditionalItems.Add("persistAuthorization", "true");
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    c.RoutePrefix = string.Empty;
  })
  .UseCors();

app.MapControllers();
app.Run();
