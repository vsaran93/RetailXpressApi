using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Transactions : BaseEntity
    {
        [Column("transaction_number")]
        public string TransactionNumber {get;set;}

        [Column("total_net_amount")]
        public double TotalNetAmount {get;set;}

        [Column("total_vat_amount")]
        public double TotalVatAmount {get;set;}

        [Column("total_gross_amount")]
        public double TotalGrossAmount {get;set;}

        [Column("payment_method")]
        public string PaymentMethod {get;set;}
    }
}