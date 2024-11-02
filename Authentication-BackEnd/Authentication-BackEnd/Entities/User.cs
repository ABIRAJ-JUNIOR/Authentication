using System.ComponentModel.DataAnnotations;

namespace Authentication_BackEnd.Entities
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; }

    }

    public enum UserRole
    {
        Admin,
        Editor,
        Viewer
    }
}
