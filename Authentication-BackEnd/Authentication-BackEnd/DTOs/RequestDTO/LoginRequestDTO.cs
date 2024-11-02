using System.ComponentModel.DataAnnotations;

namespace Authentication_BackEnd.DTOs.RequestDTO
{
    public class LoginRequestDTO
    {
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty ;

    }
}
