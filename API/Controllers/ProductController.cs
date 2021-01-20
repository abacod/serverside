using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abacode.Persistance;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Abacode.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductBusiness _products;

        public ProductController(IProductBusiness products)
        {
            _products = products;
        }

        [Route("get")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Product>), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get([FromQuery] Filter filter)
        {
            var books = _products.GetProducts(filter);
            return Ok(books);
        }

        [Route("get/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get([FromQuery] int id)
        {
            var res = _products.GetProduct(id);
            return Ok(res);
        }

        [Route("create")]
        [HttpPost]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(500)]
        public IActionResult Create([FromBody] ProductDto book)
        {
            try
            {
                var result = _products.CreateProduct(book);
                return Ok(result);
            }
            catch (BadRequestException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("editProduct")]
        [HttpPut]
        [ProducesResponseType(typeof(Product), 200)]
        [ProducesResponseType(500)]
        public IActionResult EditProduct([FromQuery] int id, [FromBody] EditProductDto bookDto)
        {
            try
            {
                var result = _products.EditProduct(id, bookDto);
                return Ok(result);
            }
            catch (BadRequestException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
