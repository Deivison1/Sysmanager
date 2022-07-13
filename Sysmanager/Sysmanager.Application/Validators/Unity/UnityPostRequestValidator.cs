using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using Sysmanager.Application.Contracts.Unity.Request;
using Sysmanager.Application.Data.Mysql.Repositories;
using Sysmanager.Application.Errors;
using Sysmanager.Application.Helpers;

namespace Sysmanager.Application.Validators
{
    public class UnityPostRequestValidator : AbstractValidator<UnityPostRequest>
    {
        public UnityPostRequestValidator(UnityRepository repository)
        {
            RuleFor(contract => contract.Name)
               .Must(name => !string.IsNullOrEmpty(name))
               .WithMessage(SysManagerErrors.Unity_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Active)
                .Must(active => active == true || active == false)
                .WithMessage(SysManagerErrors.Unity_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Name)
                .Must(name => {
                    var exists = repository.GetByNameAsync(name).Result;
                    return exists == null;
                })
                .WithMessage(SysManagerErrors.Unity_Post_BadRequest_Name_Cannot_Be_Duplicated.Description());
        }
    }
}
