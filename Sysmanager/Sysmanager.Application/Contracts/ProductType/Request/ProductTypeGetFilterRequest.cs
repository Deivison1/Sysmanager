using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Contracts.ProductType.Request
{
    public class ProductTypeGetFilterRequest
    {
        public string Name { get; set; }

        public string Active { get; set; }

        
        public int page { get; set; }
        
        public int pageSize { get; set; }
    }
}
