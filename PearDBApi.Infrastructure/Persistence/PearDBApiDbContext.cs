using Microsoft.EntityFrameworkCore;
using PearDBApi.Domain.ArchitectureAggregate;
using PearDBApi.Domain.DeviceAggregate;
using PearDBApi.Domain.DeviceTypeAggregate;
using PearDBApi.Domain.SOCAggregate;

namespace PearDBApi.Infrastructure.Persistence;

public class PearDBApiDbContext(DbContextOptions<PearDBApiDbContext> options) : DbContext(options)
{
  public required DbSet<Device> Device { get; set; }
  public required DbSet<DeviceType> DeviceType { get; set; }
  public required DbSet<Architecture> Architecture { get; set; }
  public required DbSet<Soc> Soc { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfigurationsFromAssembly(typeof(PearDBApiDbContext).Assembly);
  }
}