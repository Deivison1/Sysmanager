using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Contracts.ProductType
{
    public class ProductTypePutRequest
    {
        public string newName { get; set; }

        public bool Active { get; set; }
    }
}
