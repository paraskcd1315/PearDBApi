using System.ComponentModel.DataAnnotations.Schema;

namespace PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

public class DeviceInfoSensors
{
  public Guid Id { get; set; }

  public string? Camera { get; set; }
  public string? Biometrics { get; set; }
  public string? Microphone { get; set; }
  public string? OtherSensors { get; set; }

  public Guid DeviceInfoId { get; set; }
  public virtual DeviceInfo? DeviceInfo { get; set; }
}