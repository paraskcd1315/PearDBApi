using System.Text.Json.Serialization;
using PearDBApi.Domain.DeviceAggregate;
using PearDBApi.Domain.DeviceInfoAggregate.Enums;

namespace PearDBApi.Domain.DeviceInfoAggregate;

public class DeviceInfo
{
  public Guid Id { get; set; }

  [JsonConverter(typeof(JsonStringEnumConverter))]
  public required DeviceInfoType Type { get; set; }

  public virtual ICollection<Device>? Devices { get; set; }

  // Cores
  public int? CPUCoreCount { get; set; }
  public int? PerformanceCores { get; set; }
  public int? EfficiencyCores { get; set; }
  public string? InstructionCache { get; set; }
  public string? DataCache { get; set; }
  public string? L2Cache { get; set; }
  public string? GpuCoreCount { get; set; }
  public string? NeuralEngineCoreCount { get; set; }

  // Memory
  public string? RAM { get; set; }
  public string? Storage { get; set; }

  // Power
  public string? BatteryCapacity { get; set; }
  public string? BatteryLife { get; set; }
  public string? Charger { get; set; }

  // Connectivity
  public string? WiFi { get; set; }
  public string? Bluetooth { get; set; }
  public int? ExternalDisplayCount { get; set; }
  public string? Supports { get; set; }
  public string? Ports { get; set; }

  // Sensors
  public string? Camera { get; set; }
  public string? Biometrics { get; set; }
  public string? Microphone { get; set; }
  public string? OtherSensors { get; set; }

  // Audio
  public string? Speakers { get; set; }
  public string? Micophone { get; set; }
  public string? Channels { get; set; }
  public bool? DolbyAtmos { get; set; }
  public bool? HeadphoneJack { get; set; }

  // Input
  public string? KeyCount { get; set; }
  public string? Trackpad { get; set; }
  public bool? TouchBar { get; set; }
  public bool? TouchID { get; set; }

  // Display
  public int? ResolutionX { get; set; }
  public int? ResolutionY { get; set; }
  public string? ScreenSize { get; set; }
  public string? RefreshRate { get; set; }
  public string? PeakBrightness { get; set; }
  public string? ColorGamut { get; set; }
  public bool? TrueTone { get; set; }
  public bool? ProMotion { get; set; }
  public string? PixelsPerInch { get; set; }
}