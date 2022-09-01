using Hotel_Rental.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Core.ViewModel
{
    public class UserProductVM
    {
        public User User { get; set; }
        public List<Product> MostPickerProducts { get; set; }  
        public List<Category> Categories { get; set; }
    }
}
