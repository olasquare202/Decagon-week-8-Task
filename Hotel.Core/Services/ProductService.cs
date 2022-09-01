using Hotel.Core.Interface;
using Hotel_Rental.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAllProductsByCategoryIdAsync(int categoryId)
        {
            return await _productRepository.GetAllProductsByCategoryIdAsync(categoryId);
        }
    }
}
