using Sysmanager.Application.Contracts.ProductType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sysmanager.Application.Data.Mysql.Entities
{
    [Table("unity")]
    public class ProductTypeEntity
    {

        public ProductTypeEntity(ProductTypePostRequest unity)
        {
            this.Id = Guid.NewGuid();
            this.Name = unity.Name;
            this.Active = unity.Active;
        }

        public ProductTypeEntity(ProductTypePutRequest unity)
        {
            this.Id = unity.Id;
            this.Name = unity.Name;
            this.Active = unity.Active;
        }

        public ProductTypeEntity()
        {

        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("active")]
        public bool Active { get; set; }

    }
}
