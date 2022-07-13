using FluentValidation;
using Sysmanager.Application.Contracts.ProductType;
using Sysmanager.Application.Data.Mysql.Repositories;
using Sysmanager.Application.Errors;
using Sysmanager.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Validators.ProductType
{
    public class ProductTypePostRequestValidator : AbstractValidator<ProductTypePostRequest>
    {
        public ProductTypePostRequestValidator(ProductTypeRepository repository)
        {
            RuleFor(contract => contract.Name)
                .Must(name => !string.IsNullOrEmpty(name))
                .WithMessage(SysManagerErrors.ProductType_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Active)
                .Must(active => active == true || active == false)
                .WithMessage(SysManagerErrors.ProductType_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Name)
                .Must(name => {
                    var exists = repository.GetProductTypeByNameAsync(name);
                    return exists != null;
                })
                .WithMessage(SysManagerErrors.ProductType_Post_BadRequest_Name_Cannot_Be_Duplicated.Description());
        }
    }
}
