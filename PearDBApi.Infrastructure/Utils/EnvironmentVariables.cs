using PearDBApi.Application.Common.Constants;

namespace PearDBApi.Infrastructure.Utils;

public static class EnvironmentVariables
{
  public static string? DbConnection { get; set; } = Environment.GetEnvironmentVariable(GlobalConstants.DbConnection);
}