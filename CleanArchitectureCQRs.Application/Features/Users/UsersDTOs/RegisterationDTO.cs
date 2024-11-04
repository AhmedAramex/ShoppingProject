using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureCQRs.Application.Features.Users.UsersDTOs;

public class RegisterationDTO
{
    [Required]
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }

    public string PhoneNumber { get; set; }

}
