using Authentication_BackEnd.DTOs.RequestDTO;
using Authentication_BackEnd.DTOs.ResponseDTO;

namespace Authentication_BackEnd.IService
{
    public interface IUserService
    {
        Task<UserResponseDTO> AddUser(UserRequestDTO request);
        Task<UserResponseDTO> Login(LoginRequestDTO request);
    }
}
