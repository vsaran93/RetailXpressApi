using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Application.Products.Queries.GetProducts
{
    public class GetProductQuery: IRequest<List<Product>>
    {
        public string Id {get;set;}
        public int PageNumber {get;set;}
        public int PageSize {get;set;}
    }
}