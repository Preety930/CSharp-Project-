using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    class Transfer:Interface1
    {
        float AccBalance;
        float wdamount;
        float deposit=0;
        int Accno;

        public Transfer()
        {
            AccBalance = 40000f;
        }
        public void Deposit()
        {
            Console.WriteLine("Enter the Account Number:");
            Accno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter amount to deposit");
                deposit = Convert.ToSingle(Console.ReadLine());
                AccBalance = deposit + AccBalance;
                Console.WriteLine("Amount Deposited {0}:", deposit);
                Console.WriteLine("Account Balance: {0}:", AccBalance);
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Thank You.....!!!!!");
                Console.WriteLine(" ");

            }
            
        
        public void Withdrawal()
        {
            Console.WriteLine("Enter the Account Number:");
            Accno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount to withdraw");
            wdamount = Convert.ToSingle(Console.ReadLine());

            try
            {
                if (wdamount > AccBalance)
                    throw new InsufficientBalanceException("Insufficient balance");
                else if (AccBalance - wdamount < 3000)
                    throw new MinimumBalanceException("Minimum Balance required");
                else
                {
                    AccBalance = AccBalance - wdamount;
                    Console.WriteLine("Amount of {0} is withdrawn successfully", wdamount);
                    Console.WriteLine(" ");
                    Console.WriteLine("Account Balance is{0} ", AccBalance);
                }
            }
            catch (InsufficientBalanceException se)
            {
                Console.WriteLine(se.Message);

                Console.WriteLine("Transaction Aborted");
                Console.WriteLine(" ");
                Console.WriteLine("Please Try Again.....");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Thank You.....!!!");
            }
            
        }
        public void ViewBalance()
        {
            Console.WriteLine("Balance of your Account is: {0}", AccBalance);
            Console.WriteLine("Thank You.....!!!");
            Console.WriteLine("--------------------------");
        }

        public void DisplayAccounts()
        {
            SortedList sl = new SortedList();

            sl.Add("1000", "500000");
            sl.Add("1001", "600000");
            sl.Add("1002", "45000");
            sl.Add("1003", "90000");
            sl.Add("1004", "200000");

            Console.WriteLine(" ");
            Console.WriteLine("Account No.    Account Balance\n");
            ICollection key = sl.Keys;

            foreach (string k in key)
            {
               
                Console.WriteLine(" "+k + ":        " + sl[k]);
            }
            Console.ReadKey();
        }
    }
}
    

