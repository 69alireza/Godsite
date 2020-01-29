using Application.App.ViewModel.UserViewModel;
using Domain.App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.App.Interfaces
{
     public interface ImainService
    {
        Task<IEnumerable<Users>> GetAllUsers();
        Task<Users> Add(Users users);
        Task<Users> Find(int id);
        Task<Users> Update(Users users);
        Task<Users> Remove(int id);
        Task<bool> IsExists(int id);
    }
}
