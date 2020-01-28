using Domain.App.Interfaces;
using Domain.App.Models;
using Infrastructure.Data.App.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data.App.Repository
{

    public class UserRepository : IUserRepository
    {
        private APP_Context _ctx;
        public UserRepository(APP_Context ctx)
        {
            _ctx = ctx;
            
        }

        public IEnumerable<Users> GetAllUsers()
        {
           return _ctx.users;
        }
    }
}
