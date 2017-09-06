public class Image
{
    // belongs_to :listing, optional: true
    public int ListingId { get; set; }
    // mount_uploader :image, ImageUploader
    public int mount_uploader { get; set; }
}