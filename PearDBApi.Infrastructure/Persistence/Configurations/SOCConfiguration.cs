using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PearDBApi.Domain.SOCAggregate;

namespace PearDBApi.Infrastructure.Persistence.Configurations;

public class SocConfiguration : IEntityTypeConfiguration<Soc>
{
  public void Configure(EntityTypeBuilder<Soc> builder)
  {
    ConfigureSocTable(builder);
  }

  public static void ConfigureSocTable(EntityTypeBuilder<Soc> builder)
  {
    builder.ToTable("SOC");

    builder.HasKey(s => s.Id);

    builder
      .Property(s => s.Id)
      .ValueGeneratedNever();

    builder
      .Property(s => s.Name)
      .IsRequired();

    builder
      .HasOne(s => s.Architecture)
      .WithMany()
      .HasForeignKey(s => s.ArchitectureId);

    builder.Property(s => s.ManufacturingProcess);
  }
}