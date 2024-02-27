using ABS.Domain.Entities.Abstractions;
using ABS.Domain.Entities.Shared;

namespace ABS.Domain.Entities.Apartments;

public sealed class Apartment : Entity
{
    public Apartment(
        Guid id, 
        Name name, 
        Description description, 
        Detail detail, 
        Money price, 
        Money deposit, 
        Money cleaningFee, 
        List<Amenity> amenities,
        DateTime LastBookedOnUtc,
        Address address) : base(id)
    {
        Name = name;
        Description = description;
        Detail = detail;
        Price = price;
        Deposit = deposit;
        CleaningFee = cleaningFee;
        Amenities = amenities;
        LastBookedOnUtc = LastBookedOnUtc;
        Address = address;
    }

    public Name Name { get; private set; }
    public Description Description { get; private set; }
    public Detail Detail { get; private set; }
    public Money Price { get; private set; }
    public Money Deposit { get; private set; }
    public Money CleaningFee { get; private set; }
   
    public List<Amenity> Amenities { get; private set; }

    public DateTime LastBookedOnUtc { get; internal set; }
    public Address Address { get; private set; }
}
