using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TVShowsService.App.Interfaces.Commands.Show;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TVShowsService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShowsController : ControllerBase
    {
        private readonly IGetShowsInterface _getShowsInterface;

        public ShowsController(IGetShowsInterface getShowsInterface)
        {
            _getShowsInterface = getShowsInterface;
        }

        // GET: api/<ShowsController>
        [HttpGet]
        public IActionResult Get([FromQuery] Object shows)
        {
            return Ok(shows);
        }

        // GET api/<ShowsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ShowsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ShowsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShowsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
