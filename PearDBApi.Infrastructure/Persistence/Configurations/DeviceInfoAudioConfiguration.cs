using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceInfoAggregate;
using PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class DeviceInfoAudioConfiguration : IEntityTypeConfiguration<DeviceInfoAudio>
{
  public void Configure(EntityTypeBuilder<DeviceInfoAudio> builder)
  {
    ConfigureDeviceInfoCoresTable(builder);
  }

  public static void ConfigureDeviceInfoCoresTable(EntityTypeBuilder<DeviceInfoAudio> builder)
  {
    builder.ToTable("DeviceInfoAudio");

    builder.HasKey(di => di.Id);

    builder
      .Property(di => di.Id)
      .ValueGeneratedNever();

    builder.Property(d => d.Speakers);
    builder.Property(d => d.Micophone);
    builder.Property(d => d.Channels);
    builder.Property(d => d.DolbyAtmos);
    builder.Property(d => d.HeadphoneJack);
  }
}