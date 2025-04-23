using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceAggregate;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class DeviceConfiguration : IEntityTypeConfiguration<Device>
{
  public void Configure(EntityTypeBuilder<Device> builder)
  {
    ConfigureDeviceTable(builder);
  }

  public static void ConfigureDeviceTable(EntityTypeBuilder<Device> builder)
  {
    builder.ToTable("Device");

    builder.HasKey(d => d.Id);

    builder
      .Property(d => d.Id)
      .ValueGeneratedNever();

    builder
      .Property(d => d.Name)
      .IsRequired();

    builder
      .Property(d => d.Key)
      .IsRequired();

    builder.Property(d => d.CpId);

    builder.Property(d => d.Board);

    builder.Property(d => d.BdId);

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

    builder.Property(d => d.ReleasedDate);

    builder
      .Property(d => d.CreatedDateTime);

    builder
      .Property(d => d.UpdatedDateTime);

    builder
      .HasOne(d => d.DeviceType)
      .WithMany(dt => dt.Devices)
      .HasForeignKey(d => d.DeviceTypeId)
      .OnDelete(DeleteBehavior.Cascade);

    builder
      .HasOne(d => d.Soc)
      .WithMany()
      .HasForeignKey(d => d.SocId);

    builder
      .HasOne(d => d.Architecture)
      .WithMany()
      .HasForeignKey(d => d.ArchitectureId);
  }
}