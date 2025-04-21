using PearDBApi.Application.Common.Interfaces;

namespace PearDBApi.Infrastructure.Services;

public class DateTimeProvider : IDateTimeProvider
{
  public DateTime UtcNow => DateTime.UtcNow;
}