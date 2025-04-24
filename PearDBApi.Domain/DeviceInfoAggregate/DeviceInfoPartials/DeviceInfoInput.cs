using System.ComponentModel.DataAnnotations.Schema;

namespace PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

public class DeviceInfoInput
{
  public Guid Id { get; set; }

  public string? KeyCount { get; set; }
  public string? Trackpad { get; set; }
  public bool? TouchBar { get; set; }
  public bool? TouchID { get; set; }

  public Guid DeviceInfoId { get; set; }
  public virtual DeviceInfo? DeviceInfo { get; set; }
}