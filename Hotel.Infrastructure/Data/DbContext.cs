using Hotel_Rental.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Infrastructure.Data
{
    public class DbContext
    {
        public List<User> Users { get; set; }
        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
    }
}
