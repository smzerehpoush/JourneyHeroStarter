namespace Net.JourneyHero.Domain.BuildingBlocks.Events;

/// <summary>
/// Domain event abstraction, that stores information, when the event was occurred on.
/// </summary>
public abstract record DomainEventBase : IDomainEvent
{
    /// <inheritdoc/>
    public DateTimeOffset OccurredOn => DateTimeOffset.Now;
}