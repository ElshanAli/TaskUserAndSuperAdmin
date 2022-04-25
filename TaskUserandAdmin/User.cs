using System;
using System.Collections.Generic;
using System.Text;

namespace TaskUserandAdmin
{
    class User
    {
        private string _username;
        private string _password;

        public string Username
        {

            get

            {
                return _username;

            }
            set
            {

                if (value.Length > 6)
                {
                    _username = value;


                }
            }

        }
        public string Password
        {

            get 
            
            {
                return _password;
            
            
            }


            set
            {
                if (CheckPass(value))
                {
                    _password = value;
                }
            }

        }
        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
        public User()
        {

        }

        public bool CheckPass(string pw)
        {
            bool Digit = false;
            bool Upper = false;
            bool Lower = false;

            if (pw.Length>8)
            {
                foreach (char symbol in pw)
                {
                    if (char.IsDigit(symbol))
                    {
                        Digit = true;
                    }
                    else if (char.IsUpper(symbol))
                    {
                        Upper = true;
                    }
                    else if (char.IsLower(symbol))
                    {
                        Lower = true;
                    }

                }
                bool result = Digit && Upper && Lower;
                return result;
            }
            return false;
            
        }
    }
}
