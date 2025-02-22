namespace BankAccountSample.Methodologies.Wrong
{
    public class BankAccountWrongBalance : AbstractBalance
    {
        public override int Balance { get; protected set; }

        public override void Deposit(int amount)
        {
            Balance += amount;
        }

        public override void Withdraw(int amount)
        {
            Balance -= amount;
        }
    }
}
