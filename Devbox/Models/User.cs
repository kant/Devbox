﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Devbox.Models
{
    public class User
    {
        public int Id { get; set; }
        public ulong UserId { get; set; }
        public string PasswordHash { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Created { get; set; }
    }
}
