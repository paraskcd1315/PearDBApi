using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceInfoAggregate;
using PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class DeviceInfoPowerConfiguration : IEntityTypeConfiguration<DeviceInfoPower>
{
  public void Configure(EntityTypeBuilder<DeviceInfoPower> builder)
  {
    ConfigureDeviceInfoCoresTable(builder);
  }

  public static void ConfigureDeviceInfoCoresTable(EntityTypeBuilder<DeviceInfoPower> builder)
  {
    builder.ToTable("DeviceInfoPower");

    builder.HasKey(di => di.Id);

    builder
      .Property(di => di.Id)
      .ValueGeneratedNever();

    builder.Property(d => d.BatteryCapacity);
    builder.Property(d => d.BatteryLife);
    builder.Property(d => d.Charger);
  }
}