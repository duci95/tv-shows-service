using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using tv_shows_service.app.DTO;
using tv_shows_service.app.Interfaces.Commands;
using Newtonsoft.Json.Serialization;
using System.Text.Json;
using Newtonsoft.Json.Linq;
using tv_shows_service.app.Exceptions;

namespace tv_shows_service.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAddUserInterface _addUserInterface;

        public UsersController(IAddUserInterface addUserInterface)
        {
            _addUserInterface = addUserInterface;
        }

        

        // GET: api/Users
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        
        [HttpPost]
        public ActionResult Post([FromBody] Object user) 
        {
            try
            {
                UserInsertDTO userDTO = JsonConvert.DeserializeObject<UserInsertDTO>(user.ToString());

                if (!TryValidateModel(userDTO))
                {
                    return BadRequest();
                }

                return StatusCode(201);

            }
            catch (UniqueConstraintFailedException)
            {
                return StatusCode(422, "Values already exists!");
            }
               
            catch (Exception)
            {
                return StatusCode(500, "Server is currently under construction, try later.");
            }
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
