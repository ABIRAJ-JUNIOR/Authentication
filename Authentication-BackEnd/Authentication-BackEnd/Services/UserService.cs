using Authentication_BackEnd.DTOs.RequestDTO;
using Authentication_BackEnd.DTOs.ResponseDTO;
using Authentication_BackEnd.Entities;
using Authentication_BackEnd.IRepository;
using Authentication_BackEnd.IService;

namespace Authentication_BackEnd.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<UserResponseDTO> AddUser(UserRequestDTO request)
        {
            var user = await _userRepository.GetUserByEmail(request.Email);
            if (user == null)
            {
                var userObj = new User()
                {
                    FullName = request.FullName,
                    Email = request.Email,
                    Password = BCrypt.Net.BCrypt.HashPassword(request.Password),
                    Role = ((UserRole)request.Role).ToString(),
                };

                var userData = await _userRepository.AddUser(userObj);

                var response = new UserResponseDTO()
                {
                    UserId = userData.UserId,
                    FullName = userData.FullName,
                    Email = userData.Email,
                    Role = userData.Role,
                };

                return response;
            }
            else
            {
                throw new Exception("User already exists");
            }
        }

        public async Task<UserResponseDTO> Login(LoginRequestDTO request)
        {
            var userDetails = await _userRepository.Login(request);
            var response = new UserResponseDTO()
            {
                UserId = userDetails.UserId,
                FullName = userDetails.FullName,
                Email = userDetails.Email,
                Role = userDetails.Role,
            };

            return response;
        }
    }
}
