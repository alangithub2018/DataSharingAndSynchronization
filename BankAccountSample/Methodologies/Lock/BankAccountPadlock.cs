namespace BankAccountSamples
{
    public class BankAccountPadlock : AbstractBalance
    {
        private readonly object padlock = new object();
        public override int Balance { get; protected set; }

        public override void Deposit(int amount)
        {
            lock (padlock)
            {
                Balance += amount;
            }
        }

        public override void Withdraw(int amount)
        {
            lock (padlock)
            {
                Balance -= amount;
            }
        }
    }
}
