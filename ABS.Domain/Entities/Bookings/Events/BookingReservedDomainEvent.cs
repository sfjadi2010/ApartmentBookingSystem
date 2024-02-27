using ABS.Domain.Entities.Abstractions;

namespace ABS.Domain.Entities.Bookings.Events;

public sealed record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;