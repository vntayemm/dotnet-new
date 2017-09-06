public class Amenity
{
    public AmenityGroup Group { get; set; }
    public int MyProperty { get; set; }
}

public enum AmenityGroup
{
    regular, 
    wow, 
    disabled
}
