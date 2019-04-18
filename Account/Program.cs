using System;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account("Amir", 2500);
            Console.WriteLine($"Customer Name: {account.Customer}");
            Console.WriteLine($"Initial Cash: {account.Cash}");

            account.IncreaseCash(1500);
            Console.WriteLine($"New Cash: {account.Cash}");

            account.DecreaseCash(500);
            Console.WriteLine($"New Cash: {account.Cash}");

            account.ChangeActivation();
            Console.WriteLine($"Status: {account.IsActive}");
        }
    }
}
