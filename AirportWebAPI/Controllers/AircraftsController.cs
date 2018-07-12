using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirportWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AircraftsController : Controller
    {
        private readonly IService<Aircraft> service;

        public AircraftsController(IService<Aircraft> service)
        {
            this.service = service;
        }
        // GET: api/Aircrafts
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }

        // GET: api/Aircrafts/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var temp = service.GetById(id);
            if (temp == null) return NotFound(string.Format("Aircraft with this ID {0} not found", id));
            return Ok(temp);
        }
        
        // POST: api/Aircrafts
        [HttpPost]
        public IActionResult Post([FromBody]Aircraft value)
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
        
        // PUT: api/Aircrafts/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Aircraft value)
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
