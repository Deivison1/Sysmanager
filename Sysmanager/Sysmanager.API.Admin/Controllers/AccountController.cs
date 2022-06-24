using Microsoft.AspNetCore.Mvc;
using Sysmanager.Application.Contracts.Users.Request;
using Sysmanager.Application.Helpers;
using Sysmanager.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
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
            Console.WriteLine("Inicio do processo");
            var response = await _userService.PostAsync(request);
            return Utils.Convert(response);
        }

    }
}
