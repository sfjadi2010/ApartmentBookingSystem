using ABS.Domain.Entities.Abstractions;

namespace ABS.Domain.Entities.Users.Events;

public sealed record UserCreatedDomainEvent(Guid UserId): IDomainEvent;
