using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceInfoAggregate;
using PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

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

    builder
      .HasOne(di => di.DeviceInfoCores)
      .WithOne(di => di.DeviceInfo)
      .HasForeignKey<DeviceInfoCores>(di => di.DeviceInfoId);

    builder
      .HasOne(di => di.DeviceInfoMemory)
      .WithOne(di => di.DeviceInfo)
      .HasForeignKey<DeviceInfoMemory>(di => di.DeviceInfoId);

    builder
      .HasOne(di => di.DeviceInfoPower)
      .WithOne(di => di.DeviceInfo)
      .HasForeignKey<DeviceInfoPower>(di => di.DeviceInfoId);

    builder
      .HasOne(di => di.DeviceInfoConnectivity)
      .WithOne(di => di.DeviceInfo)
      .HasForeignKey<DeviceInfoConnectivity>(di => di.DeviceInfoId);

    builder
      .HasOne(di => di.DeviceInfoSensors)
      .WithOne(di => di.DeviceInfo)
      .HasForeignKey<DeviceInfoSensors>(di => di.DeviceInfoId);

    builder
      .HasOne(di => di.DeviceInfoAudio)
      .WithOne(di => di.DeviceInfo)
      .HasForeignKey<DeviceInfoAudio>(di => di.DeviceInfoId);

    builder
      .HasOne(di => di.DeviceInfoInput)
      .WithOne(di => di.DeviceInfo)
      .HasForeignKey<DeviceInfoInput>(di => di.DeviceInfoId);

    builder
      .HasOne(di => di.DeviceInfoDisplay)
      .WithOne(di => di.DeviceInfo)
      .HasForeignKey<DeviceInfoDisplay>(di => di.DeviceInfoId);

    builder
      .HasOne(di => di.Device)
      .WithMany(d => d.DeviceInfo)
      .HasForeignKey(di => di.DeviceId)
      .OnDelete(DeleteBehavior.Cascade);
  }
}