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
    public class StewardessesController : Controller
    {
        private readonly IService<Stewardesses> service;

        public StewardessesController(IService<Stewardesses> service)
        {
            this.service = service;
        }
        // GET: api/Stewardesses
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }

        // GET: api/Stewardesses/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var temp = service.GetById(id);
            if (temp == null) return NotFound(string.Format("Stewardesses with this ID {0} not found", id));
            return Ok(temp);
        }
        
        // POST: api/Stewardesses
        [HttpPost]
        public IActionResult Post([FromBody]Stewardesses value)
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
        
        // PUT: api/Stewardesses/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Stewardesses value)
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
                return Ok(string.Format("Stewardesses with ID {0} was successfuly deleted", id));
            }
        }
    }
}
