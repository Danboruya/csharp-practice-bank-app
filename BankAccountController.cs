using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp
{
    /// <summary>
    /// Controller of Bank account console application.
    /// </summary>
    public class BankAccountController : IBankAccountController
    {
        /// <summary>
        /// Default bank ID seed
        /// </summary>
        private static int accountNumberSeed = 1234567890;

        /// <summary>
        /// Transaction list for all bank operation
        /// </summary>
        /// <typeparam name="BankTransaction">Banking transaction model class</typeparam>
        private List<BankTransaction> transactions = new List<BankTransaction>();

        /// <inheritdoc/>
        public string Number { get; }

        /// <inheritdoc/>
        public string Owner { get; set; }

        /// <inheritdoc/>
        public decimal Balance
        {
            // At get time, return balance information from transaction history
            get
            {
                decimal balance = 0;
                foreach (BankTransaction tran in transactions)
                {
                    balance += tran.Amount;
                }
                return balance;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <c>BankAccountController</c> class.
        /// </summary>
        /// <param name="name">Account owner name</param>
        /// <param name="initialBalance">Initial balance of bank account</param>
        public BankAccountController(string name, decimal initialBalance)
        {
            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
            this.Number = GenerateBankId();
        }

        /// <inheritdoc/> 
        public string GetAccountHistory()
        {
            StringBuilder report = new StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (BankTransaction item in transactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }

        /// <inheritdoc/>
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            // If amount is non-positive, throw exception.
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            BankTransaction deposit = new BankTransaction(amount, date, note);
            transactions.Add(deposit);
        }

        /// <inheritdoc/>
        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            // If amount is non-positive, throw exception.
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positice");
            }
            // If balance is non-positive after withdrawing operation, throw exception.
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            BankTransaction withdrawal = new BankTransaction(-amount, date, note);
            transactions.Add(withdrawal);
        }

        /// <summary>
        /// Genarate unique bank account id
        /// </summary>
        /// <returns>
        /// String of bank id using calcurated from <c>accountNumberSheed</c>
        /// </returns>
        private static string GenerateBankId()
        {
            string id = accountNumberSeed.ToString();
            accountNumberSeed++;
            return id;
        }
    }
}