using System.ComponentModel.DataAnnotations.Schema;
using PearDBApi.Domain.ArchitectureAggregate;

namespace PearDBApi.Domain.SOCAggregate;

public class Soc
{
  public Guid Id { get; set; }

  public required string Name { get; set; }

  public Guid? ArchitectureId { get; set; }
  [ForeignKey(nameof(ArchitectureId))]
  public virtual Architecture? Architecture { get; set; }

  public string? ManufacturingProcess { get; set; }
}