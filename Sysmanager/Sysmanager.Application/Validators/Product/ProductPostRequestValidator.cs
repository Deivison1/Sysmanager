using FluentValidation;
using Sysmanager.Application.Contracts.Products.Request;
using Sysmanager.Application.Data.Mysql.Repositories;
using Sysmanager.Application.Errors;
using Sysmanager.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Validators.Product
{
    public class ProductPostRequestValidator : AbstractValidator<ProductPostRequest>
    {
        public ProductPostRequestValidator (ProductRepository repository)
        { 

        RuleFor(contract => contract.UserName)
                .Must(_name => !string.IsNullOrEmpty(_name))
                .WithMessage(SysManagerErrors.Product_Post_BadRequest_UserName_Cannot_Be_Null_Or_Empty.Description());

        RuleFor(contract => contract.ProductType)
                 .Must(_producttype => !string.IsNullOrEmpty(_producttype))
                 .WithMessage(SysManagerErrors.Product_Post_BadRequest_ProductType_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.ProductUnity)
              .Must(_productunity => !string.IsNullOrEmpty(_productunity))
              .WithMessage(SysManagerErrors.Product_Post_BadRequest_ProductUnity_Cannot_Be_Null_Or_Empty.Description());

        RuleFor(contract => contract.Price)
              .Must(_price => !string.IsNullOrEmpty(_price.ToString()))
              .WithMessage(SysManagerErrors.Product_Post_BadRequest_Price_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.UserName)
           .Must(name => {

               var exists = repository.GetByProductNameAsync(name).Result;
               return exists == null;
           })
           .WithMessage(SysManagerErrors.Unity_Post_BadRequest_Name_Cannot_Be_Duplicated.Description());
        }
    }
}
