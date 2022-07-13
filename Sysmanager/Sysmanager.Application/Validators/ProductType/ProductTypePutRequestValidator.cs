﻿using FluentValidation;
using Sysmanager.Application.Contracts.ProductType.Request;
using Sysmanager.Application.Data.MySql.Repositories;
using Sysmanager.Application.Errors;
using Sysmanager.Application.Helpers;

namespace Sysmanager.Application.Validators.Unity
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