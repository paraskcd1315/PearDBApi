using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceInfoAggregate;
using PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class DeviceInfoDisplayConfiguration : IEntityTypeConfiguration<DeviceInfoDisplay>
{
  public void Configure(EntityTypeBuilder<DeviceInfoDisplay> builder)
  {
    ConfigureDeviceInfoCoresTable(builder);
  }

  public static void ConfigureDeviceInfoCoresTable(EntityTypeBuilder<DeviceInfoDisplay> builder)
  {
    builder.ToTable("DeviceInfoDisplay");

    builder.HasKey(di => di.Id);

    builder
      .Property(di => di.Id)
      .ValueGeneratedNever();

    builder.Property(d => d.ResolutionX);
    builder.Property(d => d.ResolutionY);
    builder.Property(d => d.ScreenSize);
    builder.Property(d => d.RefreshRate);
    builder.Property(d => d.PeakBrightness);
    builder.Property(d => d.ColorGamut);
    builder.Property(d => d.TrueTone);
    builder.Property(d => d.ProMotion);
    builder.Property(d => d.PixelsPerInch);
  }
}