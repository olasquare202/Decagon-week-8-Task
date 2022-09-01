﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hotel.Domain.Dto.Request
{
    public class RegistrationRequestDto
    {
        [Required]
        public string FullName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)][RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid email")] public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,15}$", ErrorMessage = "Invalid password. Password should be minimum of 6 characters that include" + "alphanumeric and at least one special characters (@,$,!,%,*,#,?,&,!,^,.)")]
        public string Password { get; set; }
    }
}
