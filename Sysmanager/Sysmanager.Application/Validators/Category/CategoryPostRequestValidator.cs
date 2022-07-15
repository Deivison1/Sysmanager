using FluentValidation;
using Sysmanager.Application.Contracts.Category.Request;
using Sysmanager.Application.Data.MySql.Repositories;
using Sysmanager.Application.Errors;
using Sysmanager.Application.Helpers;

namespace Sysmanager.Application.Validators.Category
{
    public class CategoryPostRequestValidator : AbstractValidator<CategoryPostRequest>
    {

        public CategoryPostRequestValidator(CategoryRepository repository)
        {
            RuleFor(contract => contract.Name)
                .Must(name => !string.IsNullOrEmpty(name))
                .WithMessage(SysManagerErrors.Category_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Active)
                .Must(active => active == true || active == false)
                .WithMessage(SysManagerErrors.Category_Post_BadRequest_Name_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(contract => contract.Name)
                .Must(name => {
                    var exists = repository.GetCategoryByNameAsync(name);
                    return exists != null;
                })
                .WithMessage(SysManagerErrors.Category_Post_BadRequest_Name_Cannot_Be_Duplicated.Description());
        }
    }
}
