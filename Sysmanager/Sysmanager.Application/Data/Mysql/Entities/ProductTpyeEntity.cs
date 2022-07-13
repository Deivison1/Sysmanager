using Sysmanager.Application.Contracts.ProductType;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sysmanager.Application.Data.Mysql.Entities
{
    [Table("productType")]
    public class ProductTpyeEntity
    {
        public ProductTpyeEntity(ProductTypePostRequest request)
        {
            this.Id     = Guid.NewGuid();
            this.Name   = request.Name;
            this.Active = request.Active;
        }
        public ProductTpyeEntity(ProductTypePutRequest request)
        {
            this.Id = Guid.NewGuid();
            this.newName = request.newName;
            this.Active = request.Active;
        }

        public Guid Id { get; }
        [Column("name")]
        public string Name { get; set; }

        [Column("newname")]
        public string newName { get; set; }

        [Column("Active")]
        public bool Active { get; set; }
    }
}
