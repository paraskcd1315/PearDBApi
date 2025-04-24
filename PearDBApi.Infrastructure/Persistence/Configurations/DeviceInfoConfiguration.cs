using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceAggregate;
using PearDBApi.Domain.DeviceInfoAggregate;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class DeviceInfoConfiguration : IEntityTypeConfiguration<DeviceInfo>
{
  public void Configure(EntityTypeBuilder<DeviceInfo> builder)
  {
    ConfigureDeviceInfoTable(builder);
  }

  public static void ConfigureDeviceInfoTable(EntityTypeBuilder<DeviceInfo> builder)
  {
    builder.ToTable("DeviceInfo");

    builder.HasKey(di => di.Id);

    builder
      .Property(di => di.Id)
      .ValueGeneratedNever();

    builder.Property(d => d.CPUCoreCount);
    builder.Property(d => d.PerformanceCores);
    builder.Property(d => d.EfficiencyCores);
    builder.Property(d => d.InstructionCache);
    builder.Property(d => d.DataCache);
    builder.Property(d => d.L2Cache);
    builder.Property(d => d.GpuCoreCount);
    builder.Property(d => d.NeuralEngineCoreCount);

    builder.Property(d => d.RAM);
    builder.Property(d => d.Storage);

    builder.Property(d => d.BatteryCapacity);
    builder.Property(d => d.BatteryLife);
    builder.Property(d => d.Charger);

    builder.Property(d => d.WiFi);
    builder.Property(d => d.Bluetooth);
    builder.Property(d => d.ExternalDisplayCount);
    builder.Property(d => d.Supports);
    builder.Property(d => d.Ports);

    builder.Property(d => d.Camera);
    builder.Property(d => d.Biometrics);
    builder.Property(d => d.Microphone);
    builder.Property(d => d.OtherSensors);

    builder.Property(d => d.Speakers);
    builder.Property(d => d.Micophone);
    builder.Property(d => d.Channels);
    builder.Property(d => d.DolbyAtmos);
    builder.Property(d => d.HeadphoneJack);

    builder.Property(d => d.KeyCount);
    builder.Property(d => d.Trackpad);
    builder.Property(d => d.TouchBar);
    builder.Property(d => d.TouchID);

    builder.Property(d => d.ResolutionX);
    builder.Property(d => d.ResolutionY);
    builder.Property(d => d.ScreenSize);
    builder.Property(d => d.RefreshRate);
    builder.Property(d => d.PeakBrightness);
    builder.Property(d => d.ColorGamut);
    builder.Property(d => d.TrueTone);
    builder.Property(d => d.ProMotion);
    builder.Property(d => d.PixelsPerInch);

    builder
      .HasMany(di => di.Devices)
      .WithMany(d => d.DeviceInfo)
      .UsingEntity(
        "DeviceInfoDevice",
        j => j
          .HasOne(typeof(Device))
          .WithMany()
          .HasForeignKey("DeviceId")
          .HasPrincipalKey(nameof(Device.Id)),
        j => j
          .HasOne(typeof(DeviceInfo))
          .WithMany()
          .HasForeignKey("DeviceInfoId")
          .HasPrincipalKey(nameof(DeviceInfo.Id)),
        j =>
        {
          j.HasKey("DeviceId", "DeviceInfoId");
          j.ToTable("DeviceInfoDevice");
        });
  }
}