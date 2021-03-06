﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyricaDesign
{
    [Serializable]
    class User
    {
        private string login;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public User(string _login, string _password)
        {
            Login = _login;
            Password = _password;
        }

        public string print()
        {
            return (Login + " " + Password);
        }
    }
}
