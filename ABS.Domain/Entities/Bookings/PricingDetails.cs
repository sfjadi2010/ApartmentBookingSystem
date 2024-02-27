using ABS.Domain.Entities.Shared;

namespace ABS.Domain.Entities.Bookings;

public record PricingDetails(
    Money PriceForPeriod, 
    Money CleaningFee, 
    Money AmenitiesUpCharge, 
    Money TotalPrice);
