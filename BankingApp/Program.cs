using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            string password;

            Console.WriteLine("Login");
            Console.WriteLine("***************");
            Console.WriteLine("Enter Username:");
            username = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            password = Console.ReadLine();
            Login obj = new Login();
            Menu m = new Menu();
            if (obj.ValidateUser(username, password))
            {
                Console.WriteLine("Login Successfull");
                m.List();
            }
            else
            {
                Console.WriteLine("Login Failed");
            }
            Console.Read();
        }
    }
}
