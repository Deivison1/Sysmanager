using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Contracts.Unity.Request
{
    public class UnityPostRequest
    {
        /// <summary>
        /// Classe respõmsável como "contrato" de requisição para receber novas unidades de metida
        /// </summary>
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
