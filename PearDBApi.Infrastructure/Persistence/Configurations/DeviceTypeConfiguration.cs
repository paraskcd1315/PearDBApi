using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceTypeAggregate;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class DeviceTypeConfiguration : IEntityTypeConfiguration<DeviceType>
{
  public void Configure(EntityTypeBuilder<DeviceType> builder)
  {
    ConfigureDeviceTypeTable(builder);
  }

  public static void ConfigureDeviceTypeTable(EntityTypeBuilder<DeviceType> builder)
  {
    builder.ToTable("DeviceType");

    builder.HasKey(dt => dt.Id);

    builder
      .Property(dt => dt.Id)
      .ValueGeneratedNever();

    builder
      .Property(dt => dt.Name)
      .IsRequired();

    builder
      .HasMany(dt => dt.Devices)
      .WithOne(d => d.DeviceType)
      .HasForeignKey(d => d.DeviceTypeId);
  }
}