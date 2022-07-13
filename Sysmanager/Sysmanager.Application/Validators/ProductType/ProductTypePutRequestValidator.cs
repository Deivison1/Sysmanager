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
    public class ProductTypePutRequestValidator : AbstractValidator<ProductTypePutRequest>
    {
        public ProductTypePutRequestValidator(ProductTypeRepository repository)
        {
            RuleFor(contract => contract.Name)
                .Must(name => !string.IsNullOrEmpty(name))
                .WithMessage(SysManagerErrors.ProductType_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Active)
                .Must(active => active == true || active == false)
                .WithMessage(SysManagerErrors.ProductType_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty.Description());
            RuleFor(contract => contract)
                .Must(x => {
                    var exists = repository.GetProductTypeByNameAsync(x.Name).Result;

                    if (exists != null)
                        if (exists.Id != x.Id)
                            return false;

                    return true;
                })
                .WithMessage(SysManagerErrors.ProductType_Post_BadRequest_Name_Cannot_Be_Duplicated.Description());
        }
    }
}
