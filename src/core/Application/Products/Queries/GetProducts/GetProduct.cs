using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Domain.Entities;
using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Application.Products.Queries.GetProducts
{
    public class GetProductQueryHandler: IRequestHandler<GetProductQuery, List<Product>> 
    {
        private readonly IApplicationDbContext _context;

        public GetProductQueryHandler(IApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<List<Product>> Handle(GetProductQuery request, CancellationToken cancellationToken)  
        {
            return await _context.Products.ToListAsync();
        }
    }
}