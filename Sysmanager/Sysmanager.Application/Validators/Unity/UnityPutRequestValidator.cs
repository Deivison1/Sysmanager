using FluentValidation;
using Sysmanager.Application.Contracts.Unity.Request;
using Sysmanager.Application.Data.Mysql.Repositories;
using Sysmanager.Application.Errors;
using Sysmanager.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Validators.Unity
{
    public class UnityPutRequestValidator : AbstractValidator<UnityPutRequest>
    {
        public UnityPutRequestValidator(UnityRepository repository)

        {
            RuleFor(contract => contract)
            .Must(contract => {
                var exists = repository.GetByNameAsync(contract.Name).Result;

                if (exists != null)
                    if (exists.Id != contract.Id)
                        return false;
                return true;
            })
            .WithMessage(SysManagerErrors.Unity_Put_BadRequest_Name_Cannot_Be_Duplicated.Description());
            RuleFor(contract => contract.Id)
            .Must(id => {
            var exists = repository.GetByIdAsync(id).Result;
            return exists != null;
        })
            .WithMessage(SysManagerErrors.Unity_Put_BadRequest_Id_Is_Invalid_Or_Inexistent.Description());
        }
    }
}
