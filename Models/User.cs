﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace WebApplication1.Models
{
    public class User
    {
        public int id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string nickName { get; set; }
    }
}