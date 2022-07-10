using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Contracts.Products.Request
{
    public class ProductPostRequest
    {
        public string UserName { get; set; }

        public string ProductType { get; set; }

        public string ProductCategory { get; set; }

        public string ProductUnity { get; set; }

        public decimal Price { get; set; }

        public decimal Percentage{ get; set; }

    }
}
