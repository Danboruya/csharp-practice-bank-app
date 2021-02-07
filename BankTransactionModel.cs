using System;

namespace BankApp
{
    /// <summary>
    /// Banking transaction model
    /// </summary>
    public class BankTransaction
    {
        /// <summary>
        /// Amount on transaction
        /// </summary>
        public decimal Amount {get;}

        /// <summary>
        /// Transaction date
        /// </summary>
        public DateTime Date {get;}

        /// <summary>
        /// Comment on transaction
        /// </summary>
        public string Notes {get;}

        /// <summary>
        /// Initializes a new instance of the <c>BankTransaction</c> class.
        /// </summary>
        /// <param name="amount">Amount of banking operation</param>
        /// <param name="date">Transaction date</param>
        /// <param name="note">Comment for this transaction</param>
        public BankTransaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }
}