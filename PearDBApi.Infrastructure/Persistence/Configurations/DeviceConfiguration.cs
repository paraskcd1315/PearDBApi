using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceAggregate;
using PearDBApi.Domain.DeviceInfoAggregate;

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

    builder
      .HasMany(d => d.DeviceInfo)
      .WithOne(di => di.Device)
      .HasForeignKey(di => di.DeviceId);
  }
}