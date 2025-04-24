using System.ComponentModel.DataAnnotations.Schema;

namespace PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

public class DeviceInfoDisplay
{
  public Guid Id { get; set; }

  public int? ResolutionX { get; set; }
  public int? ResolutionY { get; set; }
  public string? ScreenSize { get; set; }
  public string? RefreshRate { get; set; }
  public string? PeakBrightness { get; set; }
  public string? ColorGamut { get; set; }
  public bool? TrueTone { get; set; }
  public bool? ProMotion { get; set; }
  public string? PixelsPerInch { get; set; }

  public Guid DeviceInfoId { get; set; }
  public virtual DeviceInfo? DeviceInfo { get; set; }
}