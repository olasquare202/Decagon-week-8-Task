
using Hotel_Rental.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Interface
{
    public interface IUserRepository
    {
        Task<bool> LoginAsync(string email, string password);
       // Task<User> GetByIdAsync(string id);
        Task<User> CreateAsync(User entity);

    }
}
