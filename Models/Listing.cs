using System.Collections.Generic;

public class Listing
{
    //   has_many   :uploads
    public ICollection<Upload> Uploads { get; set; }
    //   has_many   :reviews
    public ICollection<Review> Reviews { get; set; }
    //   has_many   :tips
    public ICollection<Tip> Tips { get; set; }
    //   has_many   :images, dependent: :destroy
    public ICollection<Image> Images { get; set; }
    //   has_many   :videos, dependent: :destroy
    public ICollection<Video> Videos { get; set; }
    //   has_many   :panos, dependent: :destroy
    public ICollection<Pano> Panos { get; set; }
    //   has_one    :country
    public Country Country { get; set; }
    //   has_many   :need_to_knows, dependent: :destroy
    public ICollection<NeedToKnow> NeedToKnows { get; set; }
    //   has_many   :pricing_seating_options, dependent: :destroy
    public ICollection<PricingSeatingOption> PricingSeatingOptions { get; set; }
    //   belongs_to :city
    public int CityId { get; set; }

    //   validates :name, presence: true
    public string Name { get; set; }
    //   validates :longitude, presence: true
    public double Longitude { get; set; }
    //   validates :latitude, presence: true
    public double Latitude { get; set; }

    //   has_and_belongs_to_many :amenities
    public ICollection<Amenity> Amenities { get; set; }
    //   has_and_belongs_to_many :markets
    public ICollection<Market> Markets { get; set; }
    //   has_and_belongs_to_many :spaces
    public ICollection<Space> Spaces { get; set; }
}