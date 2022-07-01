using Sysmanager.Application.Contracts.Users.Request;
using Sysmanager.Application.Data.Mysql.Entities;
using Sysmanager.Application.Data.Mysql.Repositories;
using Sysmanager.Application.Errors;
using Sysmanager.Application.Helpers;
using Sysmanager.Application.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace Sysmanager.Application.Services
{
    public class UserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            this._userRepository = userRepository;
        }
        public async Task<ResultData> PostAsync(UserPostRequest request)
        {
            var validator = new UserPostRequestValidator(_userRepository);
            var validatorResult = validator.Validate(request);

            if (!validatorResult.IsValid)
                return Utils.ErrorData(validatorResult.Errors.ToErrorList());

            var entity = new UserEntity(request);

            var response = await _userRepository.CreateUser(entity);
            Console.WriteLine("Sucesso" + DateTime.Now + "\r\n");

            return Utils.SuccessData(response);
        }
        public async Task<ResultData> PutAsync(UserPutRequest request)
        {
            var existUser = await _userRepository.GetUserByUserNameAndEmail(request.UserName, request.Email);

            if (existUser != null)
            {
                var result = await _userRepository.UpdateUser(request.NewPassword, existUser.Id);

                if (!result.HasErrors)
                    return Utils.SuccessData(result);

                return Utils.SuccessData(result);
            }
            return Utils.ErrorData(SysManagerErrors.User_Put_BadRequest_User_Not_Found.Description());
        }
    }
}
