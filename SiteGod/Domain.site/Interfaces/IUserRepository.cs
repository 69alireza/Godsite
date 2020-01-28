using Domain.App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Domain.App.Interfaces
{
     public interface IUserRepository
    {
        IEnumerable<Users> GetAllUsers();
        Task<Users> Add(Users users);
        Task<Users> Find(int id);
        Task<Users> Update(Users users);
        Task<Users> Remove(int id);
        Task<bool> IsExists(int id);
        void Save();
    }
}
