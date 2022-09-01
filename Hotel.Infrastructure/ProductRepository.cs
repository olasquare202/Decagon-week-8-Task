using Hotel.Core.Interface; 
using Hotel_Rental.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure
{
    public class ProductRepository : IProductRepository

    { 
        private readonly DbContext _dbContext;

        public ProductRepository(  DbContext dbContext)
        {
            _dbContext = dbContext; 
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {

             var product = _dbContext.Products.FirstOrDefault(x => x.Id == id);
            return product;
        }


        public async Task<List<Product>> GetAllProductsByCategoryIdAsync(int categoryId)
        {

              return _dbContext.Products.Where(x => x.CategoryId == categoryId).ToList();
        }
    }
}
       