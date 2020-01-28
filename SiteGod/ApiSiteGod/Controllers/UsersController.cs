using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.App.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiSiteGod.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private ImainService _imainService;
        public UsersController(ImainService imainService)
        {
            _imainService = imainService;
        }
        // GET: api/Users
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Users/5
        //[HttpGet("{id}", Name = "Get")]
        public IActionResult Get()
        {
            return new ObjectResult(_imainService.GetAllUsers());
        }

        // POST: api/Users
        [HttpPost]
        public void Post([FromBody] string value)
        {
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
