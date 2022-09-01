using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Interface
{
    public interface ICommandHandler
    {
        Task<bool> WriteJson<T>(SqlParameter[] model, string procedure);
        Task<T> ReadJson<T>(string procedure);
    }
}
