﻿using Sysmanager.Application.Contracts.Users.Request;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sysmanager.Application.Data.Mysql.Entities
{
    public class UserEntity
    {
        public UserEntity()
        {
        }

        public UserEntity(UserPostRequest user)
        {
            this.Id = Guid.NewGuid();
            this.UserName = user.UserName;
            this.Email = user.Email;
            this.Password = user.Password;
            this.Active = true;
        }


        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id")]
        public Guid Id { get; set; }
        [Column("userName")]
        public string UserName { get; set; }
        [Column("email")]
        public string Email { get; set; }
        [Column("password")]
        public string Password { get; set; }
        [Column("active")]
        public bool Active { get; set; }
    }
}
