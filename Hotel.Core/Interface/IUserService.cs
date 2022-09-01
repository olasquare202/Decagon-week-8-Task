using Hotel_Rental.Models;
using System.Threading.Tasks;

namespace Hotel.Core.Interface
{
    public interface IUserService
    {
        Task<User> RegisterUser(User user);

        Task<bool> Login(string email, string password);

        //Task<User> GetUserById(int id);
    }
}