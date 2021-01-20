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
    public class ServiceController : ControllerBase
    {
        private readonly IServiceBusiness _services;

        public ServiceController(IServiceBusiness services)
        {
            _services = services;
        }

        [Route("get")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Service>), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get([FromQuery] Filter filter)
        {
            var services = _services.GetServices(filter);
            return Ok(services);
        }

        [Route("get/{id}")]
        [HttpGet]
        [ProducesResponseType(typeof(Service), 200)]
        [ProducesResponseType(500)]
        public IActionResult Get([FromQuery] int id)
        {
            var service = _services.GetService(id);
            return Ok(service);
        }

        [Route("create")]
        [HttpPost]
        [ProducesResponseType(typeof(Service), 200)]
        [ProducesResponseType(500)]
        public IActionResult Create([FromBody] ServiceDto book)
        {
            try
            {
                var result = _services.CreateService(book);
                return Ok(result);
            }
            catch (BadRequestException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("editService")]
        [HttpPut]
        [ProducesResponseType(typeof(Service), 200)]
        [ProducesResponseType(500)]
        public IActionResult EditService([FromQuery] Guid id, [FromBody] EditServiceDto bookDto)
        {
            try
            {
                var result = _services.EditService(id, bookDto);
                return Ok(result);
            }
            catch (BadRequestException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
