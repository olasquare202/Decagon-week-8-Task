using Hotel_Rental.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hotel.Core.Interface
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsByCategoryIdAsync(int categoryId);
    }
}