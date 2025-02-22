namespace BankAccountSamples
{
    public class BankAccountInterlocked : AbstractBalance
    {
        private int balance;
        public override int Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }

        public override void Deposit(int amount)
        {
            Interlocked.Add(ref balance, amount);
        }

        public override void Withdraw(int amount)
        {
            Interlocked.Add(ref balance, -amount);
        }
    }
}
