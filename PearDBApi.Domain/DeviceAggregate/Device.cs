using System.ComponentModel.DataAnnotations.Schema;
using PearDBApi.Domain.ArchitectureAggregate;
using PearDBApi.Domain.DeviceInfoAggregate;
using PearDBApi.Domain.DeviceTypeAggregate;
using PearDBApi.Domain.SOCAggregate;

namespace PearDBApi.Domain.DeviceAggregate;

public class Device
{
  public Guid Id { get; set; }

  public required string Name { get; set; }

  public required string Key { get; set; }

  public string? CpId { get; set; }

  public string? Board { get; set; }

  public string? BdId { get; set; }

  public DateOnly ReleasedDate { get; set; }

  public DateTime CreatedDateTime { get; set; }
  public DateTime UpdatedDateTime { get; set; }

  public required Guid DeviceTypeId { get; set; }
  [ForeignKey(nameof(DeviceTypeId))]
  public virtual DeviceType? DeviceType { get; set; }

  public Guid? SocId { get; set; }
  [ForeignKey(nameof(SocId))]
  public virtual Soc? Soc { get; set; }

  public Guid? ArchitectureId { get; set; }
  [ForeignKey(nameof(ArchitectureId))]
  public virtual Architecture? Architecture { get; set; }

  public virtual ICollection<DeviceInfo>? DeviceInfo { get; set; }
}