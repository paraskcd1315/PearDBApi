using System.ComponentModel.DataAnnotations.Schema;

namespace PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;
public class DeviceInfoConnectivity
{
  public Guid Id { get; set; }

  public string? WiFi { get; set; }
  public string? Bluetooth { get; set; }
  public int? ExternalDisplayCount { get; set; }
  public string? Supports { get; set; }
  public string? Ports { get; set; }

  public Guid DeviceInfoId { get; set; }
  public virtual DeviceInfo? DeviceInfo { get; set; }
}