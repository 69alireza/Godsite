using Application.App.Interfaces;
using Application.App.ViewModel.UserViewModel;
using Domain.App.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.App.Services
{
    public class mainService : ImainService
    {
        private IUserRepository _userRepository;
        public mainService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public UsersViewModel GetAllUsers()
        {
            return new UsersViewModel()
            {
                Users = _userRepository.GetAllUsers()
            };
        }
    }
}
