using System;

namespace BankApp
{
    public interface IBankAccountController
    {
        /// <summary>
        /// Bank account ID
        /// </summary>
        string Number { get; }

        /// <summary>
        /// Bank account owner name
        /// </summary>
        string Owner { get; set; }

        /// <summary>
        /// Bank account balance
        /// </summary>
        decimal Balance { get; }

        /// <summary>
        /// Make deposit operation.<br/>
        /// Add balance to your banking account.
        /// </summary>
        /// <param name="amount">Deposit amount</param>
        /// <param name="date">Deposit operation date</param>
        /// <param name="note">Comment of deposit operation</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// In the case which deposit amount is non-positive value
        /// </exception>
        void MakeDeposit(decimal amount, DateTime date, string note);

        /// <summary>
        /// Make withdraw operation.<br/>
        /// Withdraw the specified amount from the balance of your bank account.
        /// </summary>
        /// <param name="amount">Withdrawal amount</param>
        /// <param name="date">withdrawing operation date</param>
        /// <param name="note">Comment of withdrawing operation</param>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// In the case which Withdrawal amount is non-positive value or 
        /// </exception>        
        void MakeWithdrawal(decimal amount, DateTime date, string note);

        /// <summary>
        /// Get the current all banking transaction history
        /// </summary>
        /// <returns>Formated all transaction history</returns>
        string GetAccountHistory();
    }
}