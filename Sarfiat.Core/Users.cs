﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarfiat.Core
{
    public class Users
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public DateTime AddedDate { get; set; }

        //Navigations
        public virtual List<UsersRoles> UsersRoles { get; set; }
    }
}
