using System;

namespace BankOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank myBank = new Bank(100);
            double x = myBank.money;

            Console.WriteLine(myBank.money);
            myBank.Deposit(35);
            Console.WriteLine(myBank.money);
            double cash = myBank.Withdraw(100000);
            Console.WriteLine($"I am holding {cash} after withdrawal. ");
            Console.WriteLine(myBank.money);
        }
    }
}
