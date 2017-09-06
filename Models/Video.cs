public class Video
{
    // belongs_to :listing, optional: true
    public int ListingId { get; set; }
    // mount_uploader :video, VideoUploader
    public string VideoUrl { get; set; }
}
