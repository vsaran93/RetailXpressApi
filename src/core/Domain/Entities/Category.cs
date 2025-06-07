using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class Category : BaseEntity
    {
        [Column("name")]
        public string Name {get; set;}
    }
}