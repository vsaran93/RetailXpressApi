using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Common
{
    public class BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set;}
    }
}