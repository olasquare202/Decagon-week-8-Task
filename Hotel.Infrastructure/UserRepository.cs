using Hotel.Core.Interface;
using System.Threading.Tasks; 
using System;
using System.IO;
using Hotel_Rental.Models;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace Hotel.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly IConfiguration _config;
        public UserRepository(IConfiguration config)
        {
            _config = config;
        }
        public async Task<User> CreateAsync(User user)
        {
            try
            {
                var connString = _config.GetSection("ConnectionStrings:DBConnection").Value;
                using (SqlConnection con = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand("spSignUp",con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Id", user.Id));
                    command.Parameters.Add(new SqlParameter("@FullName", user.FullName));
                    command.Parameters.Add(new SqlParameter("@Password", user.Password));
                    command.Parameters.Add(new SqlParameter("@Email", user.Email));
                    con.Open();
                    var affected =await command.ExecuteNonQueryAsync();
                    if (affected > 0)
                    {
                        return user;    
                    }
                    return null;

                }
            }
            catch
            {
                throw new Exception();
            }
        }

        public async Task<bool> LoginAsync(string email, string password)
        {
            try
            {
                var connString = _config.GetSection("ConnectionStrings:DBConnection").Value;
                using (SqlConnection con = new SqlConnection(connString))
                {
                    SqlCommand command = new SqlCommand("spLogin", con);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@Password", password));
                    command.Parameters.Add(new SqlParameter("@Email", email));
                    con.Open();
                    var affected = await command.ExecuteScalarAsync();
                    if (affected != null)
                    {
                        return true;
                    }
                    return false;

                }
            }
            catch
            {
                throw new Exception();
            }
        }

        //public async Task<User> GetByIdAsync(string id)
        //{

        //    var Users = await _jsonCommand.ReadJsonAsync<User>("User.json");
        //    return Users.FirstOrDefault(x => x.Id == id);
        //}

    }
}
