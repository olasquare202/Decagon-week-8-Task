using Hotel.Core.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure
{
    public class CommandHandler : ICommandHandler
    {
        //public string ConStr { get; set; }
        private readonly IConfiguration _config;
        public SqlConnection con;
        public CommandHandler(IConfiguration config)
        {
            _config = config;
            //ConStr = _config.GetConnectionString("DBConnection");
        }

        public Task<T> ReadJson<T>(string procedure)
        {
           
            //using(con = new SqlConnection(ConStr))
            //{

            //}
           

            throw new NotImplementedException();
        }

        public Task<bool> WriteJson<T>(SqlParameter[] model, string procedure)
        {
            
            throw new NotImplementedException();
        }
    }
}
