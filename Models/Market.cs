using System.Collections.Generic;

public class Market
{
    //has_and_belongs_to_many :listings
    public ICollection<Listing> Listings { get; set; }
}