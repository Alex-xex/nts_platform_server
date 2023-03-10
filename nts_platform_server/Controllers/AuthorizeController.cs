using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using nts_platform_server.Auth.JWT;
using nts_platform_server.Models;
using nts_platform_server.Services;

namespace nts_platform_server.Controllers
{
    [Route("[controller]")]
    public class AuthorizeController : Controller
    {
        private readonly IUserService _userService;
        private readonly ICompanyService _companyService;
        private readonly IDocHourseService _docHourService;

        public AuthorizeController(IUserService userService, ICompanyService companyService, IDocHourseService docHourService)
        {
            _userService = userService;
            _companyService = companyService;
            _docHourService = docHourService;
        }

        [HttpPost("login")]
        public IActionResult Authenticate(AuthenticateRequest model)
        {
            var response = _userService.Authenticate(model);

            if (response == null)
                return BadRequest(new { message = "Email or password is incorrect" });

            return Ok(response);
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserModelRegister userModel)
        {
            var response = await _userService.Register(userModel);

            if (response == null)
            {
                return BadRequest(new { message = "Didn't register!" });
            }

            return Ok(response);
        }

        [Authorize]
        [HttpGet("users")]
        public IActionResult GetAllUsers()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }


        [Authorize]
        [HttpPost("users/find")]
        public async Task<IActionResult> PostFindUserAsync(UserModelRegister user)
        {
            if (user == null)
            {
                return BadRequest(new { message = "Didn't register!" });
            }

            var response = await _userService.Find(user.Email);

            if (response == null)
            {
                return BadRequest(new { message = "User don't find!" });
            }


            return Ok(response);
        }

        [Authorize]
        [HttpDelete("users")]
        public async Task<IActionResult> DeleteUserAsync(UserModelRegister userModel)
        {
            var response = await _userService.RemoveAsync(userModel.Email);

            if (response == null)
            {
                return BadRequest(new { message = "userModel don't deleted!" });
            }

            return Ok(response);
        }

        [Authorize]
        [HttpPut("users")]
        public async Task<IActionResult> PutUserAsync([FromBody] UserModelChange userModel)
        {
            if (userModel == null)
            {
                return BadRequest(new { message = "userModel null!" });
            }

            var response = await _userService.ChangeUser(userModel);

            if (response == null)
            {
                return BadRequest(new { message = "userModel error!" });
            }

            return Ok(response);
        }

        [Authorize]
        [HttpGet("companys")]
        public IActionResult GetAllCompanys()
        {
            var companys = _companyService.GetAll();
            return Ok(companys);
        }

        [Authorize]
        [HttpPost("companys")]
        public async Task<IActionResult> PostAddCompanysAsync(CompanyModel company)
        {
            if(company != null)
            {
               if(company.Name == null)
                {
                    return BadRequest(new { message = "Company allrady added!" });
                }
            }

            var response = await _companyService.AddAsync(company.Name);

            if (response == null)
            {
                return BadRequest(new { message = "Company allrady added!" });
            }


            return Ok(response);
        }

        [Authorize]
        [HttpDelete("companys")]
        public async Task<IActionResult> DeleteCompanysAsync(CompanyModel company)
        {
            var response = await _companyService.RemoveAsync(company.Name);

            if (response == null)
            {
                return BadRequest(new { message = "Company don't deleted!" });
            }

            return Ok(response);
        }


        [Authorize]
        [HttpPost("getHours")]
        public IActionResult getHoursAsync(AuthenticateRequest userModel)
        {
            var email = userModel.Email;
            var companys = _docHourService.GetUserHours(email);

            return Ok(companys);
        }

        [Authorize]
        [HttpPost("ImportFile")]
        public async Task<IActionResult> ImportFile([FromForm] IFormFile file)
        {
            if (file == null)
                return BadRequest(new { message = "File doesn't send!" });

            Task<Entities.User> response = null;

       
            response = _userService.ChangePhoto(file);            
            
            if (response == null)
                return BadRequest(new { message = "File doesn't send!" });

            return Ok(response);
        }

        [Authorize]
        [HttpGet("ExportFile")]
        public async Task<IActionResult> GetPhoto()
        {

            var response = await _userService.TakePhoto();

            if (response == null)
            {
                return BadRequest(new { message = "User don't find!" });
            }
            Console.Write("Everything ok");

            return Ok(new { 
                message = "All are OK", 
                PhotoName = response.Profile.PhotoName, 
                PhotoByte = response.Profile.PhotoByte
           });
        }
    }
}
