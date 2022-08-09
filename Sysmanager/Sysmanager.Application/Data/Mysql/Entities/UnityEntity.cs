using Sysmanager.Application.Contracts.Unity.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sysmanager.Application.Data.Mysql.Entities
{
    [Table("unity")]
    public class UnityEntity
    {
        public UnityEntity(UnityPostRequest request)
        {
            this.Id = Guid.NewGuid();
            this.Name = request.Name;
            this.Active = request.Active;
        }
        public UnityEntity()
        {
        }

        public UnityEntity(UnityPutRequest request)
        {
            this.Id = request.Id;
            this.Name = request.Name;
            this.Active = request.Active;
        }

        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("active")]
        public bool Active { get; set; }
    }
}

