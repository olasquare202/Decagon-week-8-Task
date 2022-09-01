using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel.Domain.Dto.Response
{
    public class UserResponseDto
    {
         public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}
