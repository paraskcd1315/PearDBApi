using System.ComponentModel.DataAnnotations.Schema;

namespace PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

public class DeviceInfoPower
{
  public Guid Id { get; set; }

  public string? BatteryCapacity { get; set; }
  public string? BatteryLife { get; set; }
  public string? Charger { get; set; }

  public Guid DeviceInfoId { get; set; }
  public virtual DeviceInfo? DeviceInfo { get; set; }
}