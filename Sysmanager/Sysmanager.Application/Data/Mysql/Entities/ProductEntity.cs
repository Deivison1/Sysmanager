using Sysmanager.Application.Contracts.Products.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Sysmanager.Application.Data.Mysql.Entities
{
    public class ProductEntity
    {

        public ProductEntity()
        {

        }

        public ProductEntity(ProductPostRequest products)
        {
            this.Id = Guid.NewGuid();
            this.UserName = products.UserName;
            this.ProductType = products.ProductType;
            this.ProductCategory = products.ProductCategory;
            this.ProductUnity = products.ProductUnity;
            this.Price = products.Price;
            this.Percentage = products.Percentage;
            this.Active = true;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id")]
        public Guid Id { get; set; }

        [Column("userName")]
        public string UserName { get; set; }

        [Column("productType")]
        public string ProductType { get; set; }

        [Column("productCategory")]
        public string ProductCategory { get; set; }
        [Column("productUnity")]
        public string ProductUnity { get; set; }

        [Column("Price")]
        public decimal Price { get; set; }

        [Column("Percentage")]
        public decimal Percentage { get; set; }

        [Column("Active")]
        public bool Active { get; set; }
    }
 }
