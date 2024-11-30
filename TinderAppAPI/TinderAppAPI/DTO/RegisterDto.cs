using Data.Entities.User;
using System.ComponentModel.DataAnnotations;

public class RegisterDto
{
    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [MinLength(6)]
    public string Password { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public DateTime BirthDay { get; set; }

    [Required]
    public Gender Gender { get; set; }

    [Required]
    public InterestedIn InterestedIn { get; set; }

    [Required]
    public LookingFor LookingFor { get; set; }

    [Required]
    public SexualOrientation SexualOrientation { get; set; }

    public List<InterestDto> Interests { get; set; }
    public List<ProfilePhotoDto> ProfilePhotos { get; set; }
}

public class InterestDto
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class ProfilePhotoDto
{
    public string Path { get; set; }
}
