using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AirportWebAPI.BusinessLayer.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AirportWebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Stewardesses")]
    public class StewardessesController : Controller
    {
        // GET: api/Stewardesses
        [HttpGet]
        public IActionResult Get()
        {
            return null;
        }

        // GET: api/Stewardesses/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return null;
        }
        
        // POST: api/Stewardesses
        [HttpPost]
        public IActionResult Post([FromBody]Stewardesses value)
        {
            return null;
        }
        
        // PUT: api/Stewardesses/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Stewardesses value)
        {
            return null;
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return null;
        }
    }
}
