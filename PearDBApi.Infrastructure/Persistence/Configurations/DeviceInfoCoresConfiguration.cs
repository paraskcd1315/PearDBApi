using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.DeviceInfoAggregate;
using PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class DeviceInfoCoresConfiguration : IEntityTypeConfiguration<DeviceInfoCores>
{
  public void Configure(EntityTypeBuilder<DeviceInfoCores> builder)
  {
    ConfigureDeviceInfoCoresTable(builder);
  }

  public static void ConfigureDeviceInfoCoresTable(EntityTypeBuilder<DeviceInfoCores> builder)
  {
    builder.ToTable("DeviceInfoCores");

    builder.HasKey(di => di.Id);

    builder
      .Property(di => di.Id)
      .ValueGeneratedNever();

    builder.Property(d => d.CPUCoreCount);
    builder.Property(d => d.PerformanceCores);
    builder.Property(d => d.EfficiencyCores);
    builder.Property(d => d.InstructionCache);
    builder.Property(d => d.DataCache);
    builder.Property(d => d.L2Cache);
    builder.Property(d => d.GpuCoreCount);
    builder.Property(d => d.NeuralEngineCoreCount);
  }
}