﻿using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirportWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CrewsController : Controller
    {
        private readonly IService<Crew> service;

        public CrewsController(IService<Crew> service)
        {
            this.service = service;
        }
        // GET: api/Crew
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }

        // GET: api/Crew/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var temp = service.GetById(id);
            if (temp == null) return NotFound(string.Format("Crew with this ID {0} not found", id));
            return Ok(temp);
        }
        
        // POST: api/Crew
        [HttpPost]
        public IActionResult Post([FromBody]Crew value)
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
        
        // PUT: api/Crew/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Crew value)
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
                return Ok(string.Format("Crew with ID {0} was successfuly deleted", id));
            }
        }
    }
}
