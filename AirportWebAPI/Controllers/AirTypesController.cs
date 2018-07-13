using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirportWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AirTypesController : Controller
    {
        private readonly IService<AirType> service;

        public AirTypesController(IService<AirType> service)
        {
            this.service = service;
        }
        // GET: api/AirTypes
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }

        // GET: api/AirTypes/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var temp = service.GetById(id);
            if (temp == null) return NotFound(string.Format("AirType with this ID {0} not found", id));
            return Ok(temp);
        }
        
        // POST: api/AirTypes
        [HttpPost]
        public IActionResult Post([FromBody]AirType value)
        {
            var temp = service.AddEntry(value);
            if (temp == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(temp);
            }
        }
        
        // PUT: api/AirTypes/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]AirType value)
        {
            var temp = service.UpdateEntry(value);
            if (temp == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(temp);
            }
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var temp = service.RemoveEntry(id);
            if (temp == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(string.Format("AirType with ID {0} was successfuly deleted", id));
            }
        }
    }
}
