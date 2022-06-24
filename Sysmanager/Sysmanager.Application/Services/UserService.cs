using Sysmanager.Application.Contracts.Users.Request;
using Sysmanager.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sysmanager.Application.Services
{
     public class UserService
    {
        public UserService()
        {

        }
        public async Task<ResultData> PostAsync(UserPostRequest request)
        {
            var erros = new List<string>();

            if (request.UserName == "" || request.UserName == null)
                erros.Add("Precisa informar a propriedade (UserName)");
            if (request.Email == "" || request.Email == null)
                erros.Add("Precisa informar a propriedade (Email)");
            if (request.Password == "" || request.Password == null)
                erros.Add("Precisa informar a propriedade (Password)");
            if (erros.Count > 0)
                return Utils.ErrorData(erros);

            return Utils.SuccessData(request);
        }
    }
}
