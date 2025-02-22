namespace BankAccountSample.Methodologies.Wrong
{
    /// <summary>
    /// Represents a bank account with incorrect balance handling.
    /// </summary>
    public class BankAccountWrongBalance : AbstractBalance
    {
        public override int Balance { get; protected set; }

        /// <summary>
        /// Deposits the specified amount into the account.
        /// </summary>
        /// <param name="amount">The amount to deposit</param>
        public override void Deposit(int amount)
        {
            Balance += amount;
        }

        /// <summary>
        /// Withdraws the specified amount from the account.
        /// </summary>
        /// <param name="amount">The amount to withdraw.</param>
        public override void Withdraw(int amount)
        {
            Balance -= amount;
        }
    }
}
