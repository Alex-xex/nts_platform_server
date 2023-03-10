using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using nts_platform_server.Entities;
using nts_platform_server.Models;

namespace nts_platform_server.Services
{
    public interface IUserService
    {
        AuthenticateResponse Authenticate(AuthenticateRequest model);
        Task<AuthenticateResponse> Register(UserModelRegister userModel);
        IEnumerable<Object> GetAll();
        User GetById(int id);
        Task<User> RemoveAsync(string name);
        Task<Object> Find(string email);
        Task<IEnumerable<Object>> FindUsersInProjectAsync(string project);
        Task<User> ChangeUser(UserModelChange changeUser);
        Task<User> ChangePhoto(IFormFile file);
        Task<UserModelExtend> TakePhoto();
    }
}
