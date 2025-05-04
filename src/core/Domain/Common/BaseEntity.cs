using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Domain.Common
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set;}
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set;}
    }
}