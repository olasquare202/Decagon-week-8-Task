using Hotel.Core.Interface;
using Hotel_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        public async Task<User> RegisterUser(User user)
        {
            return await _userRepository.CreateAsync(user);
        }


        public async Task<bool> Login(string email, string password)
        {
            var users = await _userRepository.LoginAsync(email, password);
            return users;
        }

        //public async Task<User> GetUserById(string id)
        //{
        //    var user = await _userRepository.GetByIdAsync(id);
        //    return user;
        //}

        public Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
