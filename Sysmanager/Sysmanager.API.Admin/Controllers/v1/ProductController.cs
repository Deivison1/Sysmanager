using Microsoft.AspNetCore.Mvc;
using Sysmanager.Application.Contracts.Products.Request;
using Sysmanager.Application.Helpers;
using Sysmanager.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sysmanager.API.Admin.Controllers.v1
{
    public class ProductController
    {
        private readonly ProductService _productService;
        public ProductController(ProductService service)
        {
            this._productService = service;
        }

      

    }
}

