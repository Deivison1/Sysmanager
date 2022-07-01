﻿using Dapper;
using Sysmanager.Application.Contracts;
using Sysmanager.Application.Data.Mysql.Entities;
using System;
using System.Threading.Tasks;

namespace Sysmanager.Application.Data.Mysql.Repositories
{
    public class UserRepository

    {
        private readonly MySqlContext _context;

        public UserRepository(MySqlContext context)
        {
            this._context = context;
        }

        public async Task<DefaultResponse> CreateUser(UserEntity entity)
        {
            var _sql = @$"INSERT INTO user(id, userName, email, password, active)
                                     VALUE(@id, @userName, @email, @password, @active)";

            using (var cnx = _context.Connection())
            {
                var mapper = new
                {
                    id = entity.Id,
                    userName = entity.UserName,
                    email = entity.Email,
                    password = entity.Password,
                    active = entity.Active
                };

                var result = await cnx.ExecuteAsync(_sql, mapper);
                if (result > 0)

                    return new DefaultResponse(entity.Id.ToString(), "Conta criada com sucesso", false);

            }
            return new DefaultResponse("", "Erro ao tentar criar uma conta", true);

        }

        public async Task<DefaultResponse> UpdateUser(string newPassword, Guid id)
        {
            var _sql = @$"UPDATE user set password = '{newPassword}' where id = '{id}'";

            using (var cnx = _context.Connection())
            {
                var result = await cnx.ExecuteAsync(_sql);
                if (result > 0)
                    return new DefaultResponse(id.ToString(), "Senha do usuário alterada com sucesso!", false);
            }
            return new DefaultResponse(id.ToString(), "Erro ao tentar alterar a senha do usuário", true);
        }

        public async Task<UserEntity> GetUserByEmail(string email)
        {
            var _sql = $"SELECT id, userName, email, password, active from user WHERE email = '{email}' limit 1";

            using (var cnx = _context.Connection())
            {
               return await cnx.QueryFirstOrDefaultAsync<UserEntity>(_sql);
            }
        }

        public async Task<UserEntity> GetUserByUserNameAndEmail(string username, string email)
        {
            var _sql = $@"SELECT id, userName, email, password, active from user WHERE
                            username= '{username}' and email = '{email}' limit 1";

            using (var cnx = _context.Connection())
            {
                return await cnx.QueryFirstOrDefaultAsync<UserEntity>(_sql);
            }
        }

        public async Task<UserEntity> InactiveUser(Guid id)
        {
            var _sql = @$"UPDATE user set active = false where id = '{id}'";
            return new UserEntity();
        }
    }
}
