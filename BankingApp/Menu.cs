using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Menu
    {
        public void List()
        {
            while (true)
            {
                Interface1 i;
                int n;
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("-------------------------Menu-------------------------");
                Console.WriteLine("1.Deposit\n\n2.Withdrawal\n\n3.View Balance\n\n4.Display Accounts\n\n5.Logout\n");
                Console.WriteLine("Enter your choice:");
                n = Convert.ToInt32(Console.ReadLine());

                switch (n)
                {

                    case 1:
                        i = new Transfer();
                        i.Deposit();
                        break;

                    case 2:
                        i = new Transfer();
                        i.Withdrawal();
                        break;

                    case 3:
                        i = new Transfer();
                        i.ViewBalance();
                        break;

                    case 4:
                        i = new Transfer();
                        i.DisplayAccounts();
                        break;

                    case 5:
                        System.Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
        }
}
