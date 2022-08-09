using FluentValidation;
using Sysmanager.Application.Contracts.Users.Request;
using Sysmanager.Application.Data.Mysql.Repositories;
using Sysmanager.Application.Errors;
using Sysmanager.Application.Helpers;
using System;

namespace Sysmanager.Application.Validators
{
    public class UserPostRequestValidator : AbstractValidator<UserPostRequest>
    {
        public UserPostRequestValidator(UserRepository repository)
        {
            RuleFor(contract => contract.UserName)
                .Must(_name => !string.IsNullOrEmpty(_name))
                .WithMessage(SysManagerErrors.User_Post_BadRequest_UserName_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Email)
                .Must(_email => !string.IsNullOrEmpty(_email))
                .WithMessage(SysManagerErrors.User_Post_BadRequest_Email_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Password)
                .Must(_pass => !string.IsNullOrEmpty(_pass))
                .WithMessage(SysManagerErrors.User_Post_BadRequest_Password_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Email)
                .Must(email => {
                    var userExists = repository.GetUserByEmail(email).Result;
                    return userExists == null;
                })
                .WithMessage(SysManagerErrors.User_Post_BadRequest_Email_Cannot_Be_Duplicated.Description());
        }
    }
}
