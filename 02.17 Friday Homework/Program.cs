using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._17_Friday_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User test = new User();

           

            Console.WriteLine("Username daxil edin");
           string username= Console.ReadLine();

            bool IsCorrectUsername = false;

            while (!IsCorrectUsername)
            {
                IsCorrectUsername = test.IsCorrectUsername(username);

                if (IsCorrectUsername)
                {
                    break;
                }
                Console.WriteLine("Username uzunlugu 6'dan kicik ola bilmez. " +
                "Yeniden cehd edin");
                username=Console.ReadLine();
                
            }

            Console.WriteLine("Passwordu daxil edin");
            string password = Console.ReadLine();

            bool IsCorrectPassword = false;

            while (!IsCorrectPassword)
            {
                IsCorrectPassword = test.IsCorrectPassword(password);

                if (IsCorrectPassword)
                {
                    break;
                }
                Console.WriteLine("Passwordunuzda minimum bir eded ve bir boyuk herif olmalidir");
                password = Console.ReadLine();

            }
            test.SetUserInfo(username, password);

            Console.WriteLine( "Is this user a superadmin? Yes or No!");
            
            string SuperAdminStatus= Console.ReadLine();

            Console.WriteLine("Admin section'in qeyd edin");

            string section = Console.ReadLine();

            Admin admin = new Admin(SuperAdminStatus, section);
           
            admin.SetUserInfo(username, password);

            Console.WriteLine(admin.GetAdminData()); 


        }
    }
}
