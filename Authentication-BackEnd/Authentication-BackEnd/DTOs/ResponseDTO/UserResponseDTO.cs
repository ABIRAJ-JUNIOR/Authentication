using Authentication_BackEnd.Entities;
using System.ComponentModel.DataAnnotations;

namespace Authentication_BackEnd.DTOs.ResponseDTO
{
    public class UserResponseDTO
    {
        public Guid UserId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
