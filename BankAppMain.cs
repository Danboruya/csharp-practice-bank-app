using System;

namespace BankApp
{
    class BankAppMain
    {
        static void Main(string[] args)
        {
            IBankAccountController accountController = new BankAccountController("tester0", 1000000);
            Console.WriteLine($"Account {accountController.Number} was created for {accountController.Owner} with {accountController.Balance} initial balance.");

            accountController.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            Console.WriteLine(accountController.Balance);
            accountController.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            Console.WriteLine(accountController.Balance);

            Console.WriteLine(accountController.GetAccountHistory());

            // try
            // {
            //     IBankAccount testAccount = new BankAccount("tester1", -55);
            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine("Exception caught creating account with negative balance");
            //     Console.WriteLine(ex.ToString());
            // }

            // try
            // {
            //     account.MakeWithdrawal(750, DateTime.Now, "Attempt to overdraw");
            // }
            // catch (InvalidOperationException e)
            // {
            //     Console.WriteLine("Exception caught trying to overdraw");
            //     Console.WriteLine(e.ToString());
            // }
        }
    }
}
