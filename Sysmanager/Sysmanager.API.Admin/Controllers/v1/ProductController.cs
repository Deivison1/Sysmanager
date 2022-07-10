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

        #region
        [HttpPost("insert")]
        public async Task<IActionResult> Post([FromBody] ProductPostRequest request)
        {
            var response = await _productService.PostAsync(request);
            return Utils.Convert(response);
        }
        #endregion

        /*
    [HttpGet("id/{id}")]
    public async Task<IActionResult> GetById([FromRoute] Guid id)
    {
        var response = await _productsPostRequest.GetByIdAsync(id);
        return Utils.Convert(response);
    }

    [HttpPut("update")]
    public async Task<IActionResult> Put([FromBody] ProductsPostRequest request)
    {
        var response = await _unityService.PutAsync(request);
        return Utils.Convert(response);
    }

    [HttpGet("getbyfilter")]
    public async Task<IActionResult> GetByFilter([FromQuery] UnityGetFilterRequest request)
    {
        var response = await _unityService.GetByFilterAsync(request);
        return Utils.Convert(response);
    }

    [HttpDelete("id/{id}")]
    public async Task<IActionResult> DeleteById([FromRoute] Guid id)
    {
        var response = await _unityService.DeleteByIdAsync(id);
        return Utils.Convert(response);
    }
}
*/


    }
}

