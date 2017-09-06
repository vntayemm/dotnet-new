public class Booking
{
    // enum kind: [:visit, :reservation]
    public BookingKind Kind { get; set; }
    //   has_secure_token
    public bool HasSecureToken { get; set; }
    //   belongs_to :user
    public int UserId { get; set; }
    //   belongs_to :listing
    public int ListingId { get; set; }
    //   belongs_to :pricing_seating_option
    public int PricingSeatingOptionId { get; set; }
}

public enum BookingKind
{
    Visit, 
    Reservation
}