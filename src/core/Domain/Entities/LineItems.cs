using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class LineItems : BaseEntity
    {
        [Column("product_id")]
        public int ProductId {get;set;}

        [Column("quantity")]
        public int Quantity {get;set;}

        [Column("unit_price")]
        public int UnitPrice {get;set;}

        [Column("vat_rate")]
        public double VatRate {get;set;}

        [Column("vat_amount")]
        public double VatAmount { get; set; }

        [Column("gross_price")]
        public double GrossPrice {get;set;}

        [Column("transaction_id")]
        public int Transaction_id {get;set;}
    }
}