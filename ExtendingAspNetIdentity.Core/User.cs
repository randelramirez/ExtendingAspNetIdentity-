﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendingAspNetIdentity.Core
{
    public class User
    {
        public int Id { get; set; }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public DateTime Birthday { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<Role> Roles { get; set; }


    }
}
