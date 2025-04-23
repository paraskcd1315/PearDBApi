using PearDBApi.Domain.DeviceAggregate;

namespace PearDBApi.Domain.DeviceTypeAggregate;

public class DeviceType
{
  public Guid Id { get; set; }
  public required string Name { get; set; }
  public virtual ICollection<Device>? Devices { get; set; }
}