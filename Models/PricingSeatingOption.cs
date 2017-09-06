public class PricingSeatingOption
{
    //   enum group: [:tour, :booking]
    public OptionGroup Group { get; set; }
    //   enum kind:  [:day, :week, :month, :year]
    public OptionKind Kind { get; set; }
    //   belongs_to :listing, optional: true
    public int ListingId { get; set; }
}

public enum OptionGroup
{
    Tour,
    Booking
}

public enum OptionKind
{
    Day,
    Week,
    Month,
    Year
}