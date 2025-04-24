using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceInfoAggregate;
using PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class DeviceInfoMemoryConfiguration : IEntityTypeConfiguration<DeviceInfoMemory>
{
  public void Configure(EntityTypeBuilder<DeviceInfoMemory> builder)
  {
    ConfigureDeviceInfoCoresTable(builder);
  }

  public static void ConfigureDeviceInfoCoresTable(EntityTypeBuilder<DeviceInfoMemory> builder)
  {
    builder.ToTable("DeviceInfoMemory");

    builder.HasKey(di => di.Id);

    builder
      .Property(di => di.Id)
      .ValueGeneratedNever();

    builder.Property(d => d.RAM);
    builder.Property(d => d.Storage);
  }
}