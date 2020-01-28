using Application.App.Interfaces;
using Application.App.ViewModel.UserViewModel;
using Domain.App.Interfaces;
using Domain.App.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.App.Services
{
    public class mainService : ImainService
    {
        private IUserRepository _userRepository;
        public mainService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<Users> Add(Users users)
        {
           return _userRepository.Add(users);
        }

        public Task<Users> Find(int id)
        {
            return _userRepository.Find(id);
        }

        public IEnumerable<Users> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public Task<bool> IsExists(int id)
        {
            return _userRepository.IsExists(id);
        }

        public Task<Users> Remove(int id)
        {
            return _userRepository.Remove(id);
        }

        public Task<Users> Update(Users users)
        {
            return _userRepository.Update(users);
        }
      
    }
}
