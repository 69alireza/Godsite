using Domain.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.App.Interfaces
{
     public interface IUserRepository
    {
        IEnumerable<Users> GetAllUsers();
    }
}
