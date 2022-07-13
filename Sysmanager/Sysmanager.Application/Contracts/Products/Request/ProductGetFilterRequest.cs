using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Contracts.Products.Request
{
    public class ProductGetFilterRequest
    {
        public string Name { get; set; }
        
        public string Active { get; set; }

        public int page { get; set; }

        public int pagaSise { get; set; }
    }
}
