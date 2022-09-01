using Hotel.Core.Interface; 
using Hotel_Rental.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Infrastructure
{
    public class CategoryRepository : ICategoryRepository
    { 
        private readonly DbContext _dbContext;
        //create a constructor (short cut: ctor, then press tab twice)
        public CategoryRepository(DbContext dbContext)
        { 
            _dbContext = dbContext;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
             return _dbContext.Categories;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
             return _dbContext.Categories.FirstOrDefault(x => x.Id == id);
        }
    }
}
