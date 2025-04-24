using System.ComponentModel.DataAnnotations.Schema;

namespace PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

public class DeviceInfoAudio
{
  public Guid Id { get; set; }

  public string? Speakers { get; set; }
  public string? Micophone { get; set; }
  public string? Channels { get; set; }
  public bool? DolbyAtmos { get; set; }
  public bool? HeadphoneJack { get; set; }

  public Guid DeviceInfoId { get; set; }
  public virtual DeviceInfo? DeviceInfo { get; set; }
}