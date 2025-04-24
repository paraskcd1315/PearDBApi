using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceInfoAggregate;
using PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class DeviceInfoSensorsConfiguration : IEntityTypeConfiguration<DeviceInfoSensors>
{
  public void Configure(EntityTypeBuilder<DeviceInfoSensors> builder)
  {
    ConfigureDeviceInfoCoresTable(builder);
  }

  public static void ConfigureDeviceInfoCoresTable(EntityTypeBuilder<DeviceInfoSensors> builder)
  {
    builder.ToTable("DeviceInfoSensors");

    builder.HasKey(di => di.Id);

    builder
      .Property(di => di.Id)
      .ValueGeneratedNever();

    builder.Property(d => d.Camera);
    builder.Property(d => d.Biometrics);
    builder.Property(d => d.Microphone);
    builder.Property(d => d.OtherSensors);
  }
}