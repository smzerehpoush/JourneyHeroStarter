namespace Net.JourneyHero.Domain.Common.Entities;

public class AuditableEntity : Entity
{
    public string CreatedBy { get; set; } = null!;

    public DateTime Created { get; set; }

    public string? LastModifiedBy { get; set; }

    public DateTime? LastModified { get; set; }
}