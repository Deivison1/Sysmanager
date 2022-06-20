using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Contracts.Users.Request
{
    /// <summary>
    /// classe responsavel de contrato de requisicao para cadastrar um novo usuario
    /// </summary>
    public class UserPostRequest
    {
        /// <summary>
        /// Propriedade que se refere ao nome do usuario
        /// </summary>
        public String UserName{ get; set; }

        /// <summary>
        /// Propriedade que se refere ao email do usuario
        /// </summary>
        public String Email { get; set; }

        /// <summary>
        /// Propriedade que se refere a senha do usuario
        /// </summary>
        public string Password{ get; set; }
    }
}
