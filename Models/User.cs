using System.Collections.Generic;

public class User
{
    // validates :first_name, presence: true
    public string FirstName { get; set; }
    // validates :last_name, presence: true
    public string LastName { get; set; }
    // validates :email, presence: true
    public string Email { get; set; }
    // mount_uploader :avatar, AvatarUploader
    public string Avatar { get; set; }
    // has_many :bookings
    public ICollection<Booking> Bookings { get; set; }
    // has_many :lists
    public ICollection<List> Lists { get; set; }
}
