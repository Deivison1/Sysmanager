using System;
using System.Collections.Generic;
using System.Text;

namespace Sysmanager.Application.Data.Mysql.Repositories
{
    public class ProductTypeRepositoty
    {
        private readonly MySqlContext _context;

        public ProductTypeRepositoty(MySqlContext context)
        {
            this._context = context;
        }

        public async Task<DefaultResponse> CreateAsync(ProductTpyeEntity entity)
    }

}
