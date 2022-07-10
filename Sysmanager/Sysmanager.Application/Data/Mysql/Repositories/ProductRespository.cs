using Dapper;
using Sysmanager.Application.Contracts;
using Sysmanager.Application.Data.Mysql.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sysmanager.Application.Data.Mysql.Repositories
{
    public class ProductRepository
    {
        private readonly MySqlContext _context;

        public ProductRepository(MySqlContext context)
        {
            this._context = context;
        }
        public async Task<DefaultResponse> CreateProduct(ProductEntity entity)
        {
            var _sql = @$"INSERT INTO sysManager.user(id, userName, email, password, active)
                        VALUE(@id, @userName, @email, @password, @active)";

            using (var cnx = _context.Connection())
            {
                var mapper = new {
                    id = Guid.NewGuid(),
                    userName = entity.UserName,
                    productType = entity.ProductType,
                    productCategory = entity.ProductCategory,
                    productUnity = entity.ProductUnity,
                    price = entity.Price,
                    percentage = entity.Percentage,
                    active = true

                };

                var result = await cnx.ExecuteAsync(_sql, mapper);

                if (result > 0)
                    return new DefaultResponse(entity.Id.ToString(), "Conta criada com sucesso", false);
            }
            return new DefaultResponse("", "Erro ao tentar criar uma conta", true);
        }

        public async Task<UnityEntity> GetByProductNameAsync(string name)
        {
            var _sql = $"SELECT id, name, active from unity WHERE name = '{name}' limit 1";
            using (var cnx = _context.Connection())
            {
                var result = await cnx.QueryFirstOrDefaultAsync<UnityEntity>(_sql);
                return result;
            }
        }
    }

}
    

