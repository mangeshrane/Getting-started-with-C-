using System;

using AccountsLib;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            IAccount account = new SavingAccount("Mangesh", 0.0);
            account.depositeAmount(10.00);
            account.withDrawAmount(5.00);

            Console.WriteLine(account.ToString());


            Console.ReadLine();
        }
    }
}
