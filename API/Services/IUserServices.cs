using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;

namespace API.Services
{
    public interface IUserServices
    {
        Task<string> RegisterAsync(RegisterDto model);
        Task<DataUserDto> GetTokenAsynce(LoginDto model);
        Task<string> AddRolAsync(AddRolDto model);
        Task<DataUserDto> RefreshTokenAsync (string refreshToken);
    }
}