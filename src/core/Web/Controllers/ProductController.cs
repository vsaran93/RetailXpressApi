using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MediatR;
using Domain.Entities;
using Application.Products.Queries.GetProducts;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        public readonly IMediator _mediator;
        public ProductController(IMediator mediator) 
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts() 
        {
            var products = await _mediator.Send(new GetProductQuery());
            return Ok(products);
        }
    }

    
}