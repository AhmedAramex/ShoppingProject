using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureCQRs.Application.Features.Dtos;

public class RegisterationDTO
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string email { get; set; }
    [Required]
    public string password { get; set; }

    public string phoneNumber { get; set; }

}
