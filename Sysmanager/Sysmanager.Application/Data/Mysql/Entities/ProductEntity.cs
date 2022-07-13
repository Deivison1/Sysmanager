using Sysmanager.Application.Contracts.Products.Request;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sysmanager.Application.Data.Mysql.Entities
{
    public class ProductEntity
    {
        public ProductEntity(ProductPostRequest request)
        {
            this.Id            = Guid.NewGuid();
            this.Name          = request.Name;
            this.ProductCode   = request.ProductCode;
            this.ProductTypeId = request.ProductTypeId;
            this.categoryId    = request.categoryId;
            this.UnityId       = request.UnityId;
            this.costPrice     = request.costPrice;
            this.Percentage    = request.Percentage;
            this.Price         = request.Price;
            this.Active        = request.Active;

        }
        public ProductEntity()
        {

        }
        public ProductEntity(ProductPutRequest request)
        {
            this.Id            = request.Id;
            this.Name          = request.Name;
            this.ProductCode   = request.ProductCode;
            this.ProductTypeId = request.ProductTypeId;
            this.categoryId    = request.categoryId;
            this.UnityId       = request.UnityId;
            this.costPrice     = request.costPrice;
            this.Percentage    = request.Percentage;
            this.Price         = request.Price;
            this.Active        = request.Active;
        }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("id")]

        [Column("id")]
        public Guid Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("productCode")]
        public string ProductCode { get; set; }

        [Column("productTypeId")]
        public string ProductTypeId { get; set; }

        [Column("categoryId")]
        public string categoryId { get; set; }

        [Column("UnityId")]
        public string UnityId { get; set; }

        [Column("CostPrice")]
        public decimal costPrice { get; set; }

        [Column("percentage")]
        public decimal Percentage { get; set; }

        [Column("price ")]
        public decimal Price { get; set; }

        [Column("active ")]
        public bool Active { get; set; }
    }
}
        
    
            
    


 
