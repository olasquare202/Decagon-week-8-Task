using Hotel_Rental.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.Core.Interface
{
    public interface ICategoryRepository
    {
        //public static string path;
        Task<List<Category>> GetAllCategoriesAsync();
        Task<Category> GetByIdAsync(int id);
    }
}
