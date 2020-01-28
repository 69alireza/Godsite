using Domain.App.Interfaces;
using Domain.App.Models;
using Infrastructure.Data.App.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.App.Repository
{

    public class UserRepository : IUserRepository
    {
        private APP_Context _ctx;
        public UserRepository(APP_Context ctx)
        {
            _ctx = ctx;

        }

        public async Task<Users> Add(Users users)
        {
            await _ctx.users.AddAsync(users);
            Save();
            return users;
        }

        public async Task<Users> Find(int id)
        {
            return await _ctx.users.SingleOrDefaultAsync(u => u.UserId == id);
        }

        public IEnumerable<Users> GetAllUsers()
        {
            return _ctx.users;
        }

        public async Task<bool> IsExists(int id)
        {
            return await _ctx.users.AnyAsync(u => u.UserId == id);
        }

        public async Task<Users> Remove(int id)
        {
            var user = await _ctx.users.SingleAsync(u => u.UserId == id);
            _ctx.users.Remove(user);
            await _ctx.users.SingleAsync();
            return user;

        }

        public async void Save()
        {
            await _ctx.SaveChangesAsync();
        }

        public async Task<Users> Update(Users users)
        {
            _ctx.users.Update(users);
            await _ctx.SaveChangesAsync();
            return users;
        }
    }
}
