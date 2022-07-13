using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Contracts.Products.Request
{
    public class ProductPutRequest
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ProductCode { get; set; }

        public string ProductTypeId { get; set; }

        public string categoryId { get; set; }

        public string UnityId { get; set; }

        public decimal costPrice { get; set; }

        public decimal Percentage { get; set; }

        public decimal Price { get; set; }

        public bool Active { get; set; }
    }
}
