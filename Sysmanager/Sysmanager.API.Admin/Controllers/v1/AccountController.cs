using Microsoft.AspNetCore.Mvc;
using Sysmanager.Application.Contracts.Users.Request;
using Sysmanager.Application.Helpers;
using Sysmanager.Application.Services;
using System;
using System.Threading.Tasks;


namespace Sysmanager.API.Admin.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]

    public class AccountController
    {
        private readonly UserService _userService;
        public AccountController(UserService service)
        {
            this._userService = service;
        }

        [HttpPost("create-account")]
        public async Task<IActionResult> Post([FromBody] UserPostRequest request)
        {
            var response = await _userService.PostAsync(request);
            return Utils.Convert(response);
        }

        [HttpPut("recovery-account")]
        public async Task<IActionResult> Put([FromBody] UserPutRequest request)
        {
            var response = await _userService.PutAsync(request);
            return Utils.Convert(response);
        }

        [HttpPost("login")]
        public async Task<IActionResult> PostLogin([FromBody] UserPostLoginRequest request)
        {
            var response = await _userService.PostLoginAsync(request);
            return Utils.Convert(response);
        }
    }
}