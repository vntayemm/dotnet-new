using System.Collections.Generic;

public class Amenity
{
    public AmenityGroup Group { get; set; }
    public ICollection<Listing> Listings { get; set; }
}

public enum AmenityGroup
{
    Regular, 
    Wow, 
    Disabled
}
