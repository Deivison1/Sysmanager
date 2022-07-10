using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Contracts.Unity.Request
{
    public  class UnityPutRequest
    {
        /// <summary>
        /// Classe responsável como "contrato" de requisição para receber uma alteração de uma unidade metida
        /// </summary>
        
        public Guid Id { get; set; }

        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
