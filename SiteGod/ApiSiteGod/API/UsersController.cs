using Application.App.Interfaces;
using Domain.App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiSiteGod.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private ImainService _mainService;

        public UsersController(ImainService mainService)
        {
            _mainService = mainService;
        }

        // GET: api/Users
        [HttpGet]
        public Task<IEnumerable<Users>> Getusers()
        {
            return _mainService.GetAllUsers();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> GetUsers(int id)
        {
            if(await UsersExists(id))
            {
              var user = await _mainService.Find(id);
                return Ok(user);
            }
            else
            {
                return NotFound();
            }
      
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsers(int id, Users users)
        {
            if (id != users.UserId)
            {
                return BadRequest();
            }

            await _mainService.Update(users);

            return Ok(users);
        }

        // POST: api/Users
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Users>> PostUsers(Users users)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _mainService.Add(users);

            return users;
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Users>> DeleteUsers(int id)
        {
            var users = await _mainService.IsExists(id);
            if (users == false)
            {
                return NotFound();
            }

             await _mainService.Remove(id);
            return Ok();
        }

        private async Task<bool> UsersExists(int id)
        {
            return await _mainService.IsExists(id);
        }
    }
}
