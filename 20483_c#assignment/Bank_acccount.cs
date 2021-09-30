using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Bank_account
    {
        int min_balance, balance1;
        public Bank_account(int balance1)
        {
            min_balance = 500;
            this.balance1 = balance1;
        }
        public static void Main()
        {
            Bank_account balance = new Bank_account(600);
            Console.WriteLine("default_balance=" + balance.min_balance);
            Console.WriteLine("new_balance=" + balance.balance1);
        }
    }
}
