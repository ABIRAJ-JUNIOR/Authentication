using Authentication_BackEnd.DTOs.RequestDTO;
using Authentication_BackEnd.Entities;

namespace Authentication_BackEnd.IRepository
{
    public interface IUserRepository
    {
        Task<User> AddUser(User user);
        Task<User> GetUserByEmail(string email);
        Task<User> Login(LoginRequestDTO request);
    }
}
