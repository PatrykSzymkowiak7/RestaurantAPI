﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace RestaurantAPI.Models
{
    public class LoginDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
