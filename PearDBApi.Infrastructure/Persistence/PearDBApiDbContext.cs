using Microsoft.EntityFrameworkCore;
using PearDBApi.Domain.ArchitectureAggregate;
using PearDBApi.Domain.DeviceAggregate;
using PearDBApi.Domain.DeviceInfoAggregate;
using PearDBApi.Domain.DeviceInfoAggregate.DeviceInfoPartials;
using PearDBApi.Domain.DeviceTypeAggregate;
using PearDBApi.Domain.SOCAggregate;

namespace PearDBApi.Infrastructure.Persistence;

public class PearDBApiDbContext(DbContextOptions<PearDBApiDbContext> options) : DbContext(options)
{
  public required DbSet<Device> Device { get; set; }
  public required DbSet<DeviceInfo> DeviceInfo { get; set; }
  public required DbSet<DeviceInfoSensors> DeviceInfoSensors { get; set; }
  public required DbSet<DeviceInfoMemory> DeviceInfoMemory { get; set; }
  public required DbSet<DeviceInfoPower> DeviceInfoPower { get; set; }
  public required DbSet<DeviceInfoAudio> DeviceInfoAudio { get; set; }
  public required DbSet<DeviceInfoInput> DeviceInfoInput { get; set; }
  public required DbSet<DeviceInfoDisplay> DeviceInfoDisplay { get; set; }
  public required DbSet<DeviceInfoCores> DeviceInfoCores { get; set; }
  public required DbSet<DeviceInfoConnectivity> DeviceInfoConnectivity { get; set; }
  public required DbSet<DeviceType> DeviceType { get; set; }
  public required DbSet<Architecture> Architecture { get; set; }
  public required DbSet<Soc> Soc { get; set; }


  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(PearDBApiDbContext).Assembly);
  }
}