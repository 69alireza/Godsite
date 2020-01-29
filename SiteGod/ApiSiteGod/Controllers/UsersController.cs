﻿using Application.App.Interfaces;
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
            var IsExists = await _mainService.IsExists(id);

            if (IsExists == false)
            {
                return NotFound();
            }

            return await _mainService.Find(id);
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

            return NoContent();
        }

        // POST: api/Users
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Users>> PostUsers(Users users)
        {
            await _mainService.Add(users);

            return CreatedAtAction("GetUsers", new { id = users.UserId }, users);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Users>> DeleteUsers(int id)
        {
            var users = await _mainService.Find(id);
            if (users == null)
            {
                return NotFound();
            }

            await _mainService.Remove(id);

            return users;
        }

        private async Task<bool> UsersExists(int id)
        {
            return await _mainService.IsExists(id);
        }
    }
}
