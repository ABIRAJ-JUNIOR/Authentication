using Authentication_BackEnd.DBContext;
using Authentication_BackEnd.DTOs.RequestDTO;
using Authentication_BackEnd.Entities;
using Authentication_BackEnd.IRepository;
using Microsoft.EntityFrameworkCore;

namespace Authentication_BackEnd.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDBContext _dBContext;

        public UserRepository(AppDBContext dBContext)
        {
            _dBContext = dBContext;
        }


        public async Task<User> AddUser(User user)
        {
            var userDetails = await _dBContext.users.AddAsync(user);
            await _dBContext.SaveChangesAsync();
            return userDetails.Entity;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            var user = await _dBContext.users.SingleOrDefaultAsync(u => u.Email == email);
            return user!;
        }

        public async Task<User> Login(LoginRequestDTO request)
        {
            var user = await GetUserByEmail(request.Email);
            if (user == null)
            {
                throw new Exception("User not found");
            }

            var isLogin = BCrypt.Net.BCrypt.Verify(request.Password , user.Password);
            if (isLogin)
            {
                return user;
            }
            else
            {
                throw new Exception("Invalid password");
            }
        }
    }
}
