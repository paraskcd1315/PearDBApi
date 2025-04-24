using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceInfoAggregate;
using PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class DeviceInfoConnectivityConfiguration : IEntityTypeConfiguration<DeviceInfoConnectivity>
{
  public void Configure(EntityTypeBuilder<DeviceInfoConnectivity> builder)
  {
    ConfigureDeviceInfoCoresTable(builder);
  }

  public static void ConfigureDeviceInfoCoresTable(EntityTypeBuilder<DeviceInfoConnectivity> builder)
  {
    builder.ToTable("DeviceInfoConnectivity");

    builder.HasKey(di => di.Id);

    builder
      .Property(di => di.Id)
      .ValueGeneratedNever();

    builder.Property(d => d.WiFi);
    builder.Property(d => d.Bluetooth);
    builder.Property(d => d.ExternalDisplayCount);
    builder.Property(d => d.Supports);
    builder.Property(d => d.Ports);
  }
}