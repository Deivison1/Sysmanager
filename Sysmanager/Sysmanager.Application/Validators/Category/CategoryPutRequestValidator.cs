using FluentValidation;
using Sysmanager.Application.Contracts.Category.Request;
using Sysmanager.Application.Data.Mysql.Repositories;
using Sysmanager.Application.Errors;
using Sysmanager.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Validators.Category
{
    public class CategoryPutRequestValidator : AbstractValidator<CategoryPutRequest>
    {
        public CategoryPutRequestValidator(CategoryRepository repository)
        {
            RuleFor(contract => contract.Name)
                .Must(name => !string.IsNullOrEmpty(name))
                .WithMessage(SysManagerErrors.Category_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Active)
                .Must(active => active == true || active == false)
                .WithMessage(SysManagerErrors.Category_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty.Description());
            RuleFor(contract => contract)
                .Must(x => {
                    var exists = repository.GetUnityByNameAsync(x.Name).Result;

                    if (exists != null)
                        if (exists.Id != x.Id)
                            return false;

                    return true;
                })
                .WithMessage(SysManagerErrors.Category_Post_BadRequest_Name_Cannot_Be_Duplicated.Description());
        }
    }
}
