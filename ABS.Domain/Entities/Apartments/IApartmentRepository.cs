namespace ABS.Domain.Entities.Apartments;

public interface IApartmentRepository
{
    Task<Apartment> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
}
