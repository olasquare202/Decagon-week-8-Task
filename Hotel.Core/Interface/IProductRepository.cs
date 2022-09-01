using Hotel_Rental.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Interface
{
    public interface IProductRepository
    {

        Task<Product> GetProductByIdAsync(int id);
        Task<List<Product>> GetAllProductsByCategoryIdAsync(int categoryId);
    }
}

