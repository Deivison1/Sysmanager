using Sysmanager.Application.Contracts.Unity.Request;
using Sysmanager.Application.Data.Mysql.Entities;
using Sysmanager.Application.Data.Mysql.Repositories;
using Sysmanager.Application.Errors;
using Sysmanager.Application.Helpers;
using Sysmanager.Application.Validators;
using Sysmanager.Application.Validators.Unity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sysmanager.Application.Services
{
    public class UnityService
    {
        private readonly UnityRepository _unityRepository;
        private UnityRepository @object;

        public UnityService(UnityRepository unityRepository, Data.MySql.Repositories.ProductRepository _productRepository)
        {
            this._unityRepository = unityRepository;
        }

        public UnityService(UnityRepository @object)
        {
            this.@object = @object;
        }

        public virtual async Task<ResultData> PostAsync(UnityPostRequest request)
        {
            var validator = new UnityPostRequestValidator(_unityRepository);
            var validatorResult = validator.Validate(request);

            if (!validatorResult.IsValid)
                return Utils.ErrorData(validatorResult.Errors.ToErrorList());

            var entity = new UnityEntity(request);
            var response = await _unityRepository.CreateAsync(entity);
            return Utils.SuccessData(response);
        }
        public virtual async Task<ResultData> PutAsync(UnityPutRequest request)
        {
            var validator = new UnityPutRequestValidator(_unityRepository);
            var validatorResult = validator.Validate(request);

            if (!validatorResult.IsValid)
                return Utils.ErrorData(validatorResult.Errors.ToErrorList());

            var entity = new UnityEntity(request);
            var response = await _unityRepository.UpdateAsync(entity);
            return Utils.SuccessData(response);
        }
        public virtual async Task<ResultData> GetByIdAsync(Guid id)
        {
            var response = await _unityRepository.GetByIdAsync(id);

            if (response != null)
                return Utils.SuccessData(response);

            return Utils.ErrorData(SysManagerErrors.Unity_Get_BadRequest_Id_Is_Invalid_Or_Inexistent.Description());
        }

        public virtual async Task<ResultData> GetByFilterAsync(UnityGetFilterRequest request)
        {
            var result = await _unityRepository.GetByFilterAsync(request);
            return Utils.SuccessData(result);
        }

        public virtual async Task<ResultData> DeleteByIdAsync(Guid id)
        {
            var response = await _unityRepository.GetByIdAsync(id);
            if (response != null)
            {
                var result = await _unityRepository.DeleteByIdAsync(id);
                return Utils.SuccessData(result);
            }
            return Utils.ErrorData(SysManagerErrors.Unity_Delete_BadRequest_Id_Is_Invalid_Or_Inexistent.Description());
        }

    }
}

