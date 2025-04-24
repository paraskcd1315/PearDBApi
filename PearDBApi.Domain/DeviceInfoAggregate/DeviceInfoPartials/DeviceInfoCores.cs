using System.ComponentModel.DataAnnotations.Schema;

namespace PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

public class DeviceInfoCores
{
  public Guid Id { get; set; }

  public int? CPUCoreCount { get; set; }
  public int? PerformanceCores { get; set; }
  public int? EfficiencyCores { get; set; }
  public string? InstructionCache { get; set; }
  public string? DataCache { get; set; }
  public string? L2Cache { get; set; }
  public string? GpuCoreCount { get; set; }
  public string? NeuralEngineCoreCount { get; set; }

  public Guid DeviceInfoId { get; set; }
  public virtual DeviceInfo? DeviceInfo { get; set; }
}