namespace BankAccountSamples
{
    public class BankAccountInterlocked : AbstractBalance
    {
        private int balance;
        public override int Balance
        {
            get { return Interlocked.CompareExchange(ref balance, 0, 0); }
            protected set { Interlocked.Exchange(ref balance, value); }
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
