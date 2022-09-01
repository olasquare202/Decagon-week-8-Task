using Hotel_Rental.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.Core.Interface
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllCategoriesAsync();
    }
}