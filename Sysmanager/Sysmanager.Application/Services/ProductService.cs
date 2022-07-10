using Sysmanager.Application.Contracts.Products.Request;
using Sysmanager.Application.Data.Mysql.Entities;
using Sysmanager.Application.Data.Mysql.Repositories;
using Sysmanager.Application.Helpers;
using Sysmanager.Application.Validators.Product;
using System.Threading.Tasks;

namespace Sysmanager.Application.Services
{
    public class ProductService
    {
        private readonly ProductRepository _productRepository;

        public ProductService(ProductRepository unityRepository)
        {
            this._productRepository = unityRepository;
        }

        public async Task<ResultData> PostAsync(ProductPostRequest request)
        {
            var validator = new ProductPostRequestValidator(_productRepository);
            var validatorResult = validator.Validate(request);

            if (!validatorResult.IsValid)
                return Utils.ErrorData(validatorResult.Errors.ToErrorList());
            var entity = new ProductEntity(request);
            var response = await _productRepository.CreateProduct(entity);
            return Utils.SuccessData(response);

        }
    }
}
