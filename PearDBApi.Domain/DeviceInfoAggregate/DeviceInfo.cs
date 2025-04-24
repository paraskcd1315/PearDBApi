using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using PearDBApi.Domain.DeviceAggregate;
using PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;
using PearDBApi.Domain.DeviceInfoAggregate.Enums;

namespace PearDBApi.Domain.DeviceInfoAggregate;

public class DeviceInfo
{
  public Guid Id { get; set; }

  [JsonConverter(typeof(JsonStringEnumConverter))]
  public required DeviceInfoType Type { get; set; }

  public required Guid DeviceId { get; set; }
  [ForeignKey(nameof(DeviceId))]
  public virtual Device? Device { get; set; }

  // Cores
  public Guid? DeviceInfoCoresId { get; set; }
  [ForeignKey(nameof(DeviceInfoCoresId))]
  public virtual DeviceInfoCores? DeviceInfoCores { get; set; }

  // Memory
  public Guid? DeviceInfoMemoryId { get; set; }
  [ForeignKey(nameof(DeviceInfoMemoryId))]
  public virtual DeviceInfoMemory? DeviceInfoMemory { get; set; }

  // Power
  public Guid? DeviceInfoPowerId { get; set; }
  [ForeignKey(nameof(DeviceInfoPowerId))]
  public virtual DeviceInfoPower? DeviceInfoPower { get; set; }

  // Connectivity
  public Guid? DeviceInfoConnectivityId { get; set; }
  [ForeignKey(nameof(DeviceInfoConnectivityId))]
  public virtual DeviceInfoConnectivity? DeviceInfoConnectivity { get; set; }

  // Sensors
  public Guid? DeviceInfoSensorsId { get; set; }
  [ForeignKey(nameof(DeviceInfoSensorsId))]
  public virtual DeviceInfoSensors? DeviceInfoSensors { get; set; }

  // Audio
  public Guid? DeviceInfoAudioId { get; set; }
  [ForeignKey(nameof(DeviceInfoAudioId))]
  public virtual DeviceInfoAudio? DeviceInfoAudio { get; set; }

  // Input
  public Guid? DeviceInfoInputId { get; set; }
  [ForeignKey(nameof(DeviceInfoInputId))]
  public virtual DeviceInfoInput? DeviceInfoInput { get; set; }

  // Display
  public Guid? DeviceInfoDisplayId { get; set; }
  [ForeignKey(nameof(DeviceInfoDisplayId))]
  public virtual DeviceInfoDisplay? DeviceInfoDisplay { get; set; }
}