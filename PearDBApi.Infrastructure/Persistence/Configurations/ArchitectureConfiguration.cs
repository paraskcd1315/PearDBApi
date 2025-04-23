using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.ArchitectureAggregate;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class ArchitectureConfiguration : IEntityTypeConfiguration<Architecture>
{
  public void Configure(EntityTypeBuilder<Architecture> builder)
  {
    ConfigureArchitectureTable(builder);
  }

  public static void ConfigureArchitectureTable(EntityTypeBuilder<Architecture> builder)
  {
    builder.ToTable("Architecture");

    builder.HasKey(a => a.Id);

    builder
        .Property(a => a.Id)
        .ValueGeneratedNever();

    builder
        .Property(a => a.Name)
        .IsRequired();
  }
}