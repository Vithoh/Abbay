﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class User
    {
        private string _userName;
        private string _firstName;
        private string _lastName;
        private string _email;
        private bool _admin;
        private string _password;
        private string _salt;

        public User()
        {

        }

        public User(string username, string firstname, string lastname, string passwrod, string email)
        {
            UserName = username;
            FirstName = firstname;
            LastName = lastname;
            Password = passwrod;
            Email = email;
        }

        public string UserName { get => _userName; set => _userName = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Email { get => _email; set => _email = value; }
        public bool Admin { get => _admin; set => _admin = value; }
        public string Password { get => _password; set => _password = value; }
        public string Salt { get => _salt; set => _salt = value; }
    }
}
