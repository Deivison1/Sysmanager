using Microsoft.AspNetCore.Mvc;
using Sysmanager.Application.Contracts.Users.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.API.Admin.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]

    public class AccountController
    {
        public AccountController()
        {

        }
        [HttpPost("create-account")]
        public async Task<string> Post(UserPostRequest request) 
        {
            return "Requisição efetuada com sucesso!";
        }

        [HttpPost("login")]
        public async Task<string> PostLogin(string obj)
        {
            return "Requisição efetuada com sucesso!";
        }

    }
}
