using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Entities
{
    public class SubCategory : BaseEntity
    {
        [Column("category_id")]
        public int CategoryId {get;set;}

        [Column("name")]
        public string Name {get;set}
    }
}