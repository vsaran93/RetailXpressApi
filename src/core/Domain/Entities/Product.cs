using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table("products")]
    public class Product : BaseEntity
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description {get; set;}

        [Column("category_id")]
        public int CategoryId {get;set;}

        [Column("sub_category_id")]
        public int SubCategoryId {get;set;}

        [Column("price")]
        public double Price {get;set;}

        [Column("product_code")]
        public string ProductCode {get;set;}
    }
}