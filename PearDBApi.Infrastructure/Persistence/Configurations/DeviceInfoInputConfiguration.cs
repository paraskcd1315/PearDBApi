using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceInfoAggregate;
using PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class DeviceInfoInputConfiguration : IEntityTypeConfiguration<DeviceInfoInput>
{
  public void Configure(EntityTypeBuilder<DeviceInfoInput> builder)
  {
    ConfigureDeviceInfoCoresTable(builder);
  }

  public static void ConfigureDeviceInfoCoresTable(EntityTypeBuilder<DeviceInfoInput> builder)
  {
    builder.ToTable("DeviceInfoInput");

    builder.HasKey(di => di.Id);

    builder
      .Property(di => di.Id)
      .ValueGeneratedNever();

    builder.Property(d => d.KeyCount);
    builder.Property(d => d.Trackpad);
    builder.Property(d => d.TouchBar);
    builder.Property(d => d.TouchID);
  }
}