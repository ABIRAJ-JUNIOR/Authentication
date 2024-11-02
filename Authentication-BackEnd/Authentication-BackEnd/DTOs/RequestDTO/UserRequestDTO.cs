using Authentication_BackEnd.Entities;
using System.ComponentModel.DataAnnotations;

namespace Authentication_BackEnd.DTOs.RequestDTO
{
    public class UserRequestDTO
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserRole Role { get; set; }
    }
}
