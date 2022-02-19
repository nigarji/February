using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._17_Friday_Homework
{
    internal class User
    {

        private string Username;
        private string Password;
        public User( )
        {

        }
        public string GetUserInfo()
        {
            return $" Username: {Username} \n Password: { Password}";
        }
        public void SetUserInfo(string username, string password)
        {
            Username=username;
            Password=password;
        }

        public bool IsCorrectUsername (string username)
        {
            if (username.Length>6)
            {
               
               return true;
            }
           return false;

        }

        public bool IsCorrectPassword(string password)

        {
            bool hasDigit = false;

            bool hasLetter = false;
            foreach (char element in password)

            {

                if (char.IsDigit(element))

                {
                    hasDigit = true;

                }
                if (char.IsUpper(element))

                {
                    hasLetter = true;

                }

                if (hasDigit && hasLetter)

                {

                    return true;
                }
                
            }
            return false;
        }
    }
}
