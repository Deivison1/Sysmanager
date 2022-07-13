using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Contracts.ProductType
{
    public class ProductTypePostRequest
    {
        public string Name { get; set; }

        public bool Active { get; set; }
    }
}
