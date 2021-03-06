﻿using Application.App.Interfaces;
using Application.App.ViewModel.UserViewModel;
using Domain.App.Interfaces;
using Domain.App.Models;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.App.Services
{
    public class mainService : ImainService
    {
       
        private IGenericRepository<Users> _userRepository;
        private IMemoryCache _Cache;
       
        private const string userCacheKey = "getalluser-cache-key";
        public mainService(IGenericRepository<Users> userRepository, IMemoryCache cache)
        {

            _userRepository = userRepository;
            _Cache = cache;
        }

        public Task<Users> Add(Users users)
        {
           return _userRepository.Add(users);
        }

        public async Task<Users> Find(int id)
        {
            //    var cacheuser = _Cache.Get<Users>(id);
            //    if(cacheuser != null)
            //    {
            //        return  cacheuser;
            //    }
            //    else
            //    {
            var user = await _userRepository.Find(U=>U.UserId == id);
                //var cacheOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(60));
                // _Cache.Set(user.UserId, user, cacheOptions);
                return  user;
            //}
          
        }

        public async Task<IEnumerable<Users>> GetAllUsers()
        
        {
            //if (!_Cache.TryGetValue("UserList", out IEnumerable<Users> users))
            //{
            //    if (users == null)
            //    {
                   var users =await _userRepository.Get();
            //    }
            //    var cacheEntryOptions = new MemoryCacheEntryOptions()
            //// Keep in cache for this time, reset time if accessed.
            //.SetAbsoluteExpiration(TimeSpan.FromSeconds(60));

            //    _Cache.Set("UserList", users, cacheEntryOptions);
            //}
            return users;

        }

        public Task<bool> IsExists(int id)
        {
            return _userRepository.IsExists(U=>U.UserId == id);
        }

        public Task<Users> Remove(int id)
        {
            return _userRepository.Remove(u=>u.UserId == id);
        }

        public Task<Users> Update(Users users)
        {
            return _userRepository.Update(users);
        }
      
    }
}
