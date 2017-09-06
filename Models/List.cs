using System.Collections.Generic;

public class List 
{
    public int UserId { get; set; }
    public ICollection<ListListing> List_Listtings { get; set; }
    public ICollection<Listing> Listings { get; set; }
}