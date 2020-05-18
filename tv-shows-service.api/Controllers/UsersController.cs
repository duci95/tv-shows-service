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
                var json = (JObject)JsonConvert.DeserializeObject(user.ToString());

                UserDTO userDTO = new UserDTO
                {
                    Email = (string)json["email"],
                    FirstName = (string)json["firstname"],
                    LastName = (string)json["lastname"],
                    Username = (string)json["username"],
                    Password = (string)json["password"],
                    PasswordRepeat = (string)json["passwordRepeat"]
                };

                _addUserInterface.Execute(userDTO);
                return StatusCode(201);
            }
            catch (UniqueConstraintFailedException)
            {
                return StatusCode(422, "Validation error!");
            }
            catch (Exception)
            {
                return StatusCode(500);
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
