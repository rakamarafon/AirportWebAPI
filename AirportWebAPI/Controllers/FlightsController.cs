using AirportWebAPI.BusinessLayer.DTO;
using AirportWebAPI.BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AirportWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class FlightsController : Controller
    {
        private readonly IService<Flight> service;

        public FlightsController(IService<Flight> service)
        {
            this.service = service;
        }
        // GET: api/Flights
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(service.GetAll());
        }

        // GET: api/Flights/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var temp = service.GetById(id);
            if (temp == null) return NotFound(string.Format("Flight with this ID {0} not found", id));
            return Ok(temp);
        }
        
        // POST: api/Flights
        [HttpPost]
        public IActionResult Post([FromBody]Flight value)
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
        
        // PUT: api/Flights/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Flight value)
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
                return Ok(string.Format("Flight with ID {0} was successfuly deleted", id));
            }
        }
    }
}
