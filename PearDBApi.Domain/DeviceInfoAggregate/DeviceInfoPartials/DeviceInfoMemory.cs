using System.ComponentModel.DataAnnotations.Schema;

namespace PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

public class DeviceInfoMemory
{
  public Guid Id { get; set; }

  public string? RAM { get; set; }
  public string? Storage { get; set; }

  public Guid DeviceInfoId { get; set; }
  public virtual DeviceInfo? DeviceInfo { get; set; }
}