﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.JournalClasses
{
    public class Login
    {
        public string userName { get; set; }
        public string password { get; set; }

        public Login(string userName, string password)
        {
            this.userName = userName;
            this.password = password;
        }
    }
}
