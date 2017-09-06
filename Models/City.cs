public class City
{
    //   belongs_to :country
    public int CountryId { get; set; }
    //   validates :name, presence: true
    public string Name { get; set; }
    //   validates :slug, presence: true
    public string Slug { get; set; }
}


