using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Contracts.Products.Request
{
    public class ProductGetFilterRequest
    {
        public string Name { get; set; }

        public string Active { get; set; }

        public string CategoryId { get; set; }

        public string ProductTypeId { get; set; }

        public string UnityId { get; set; }

       
        public int page { get; set; }
       
        public int pageSize { get; set; }
    }
}
