namespace BankAccountSample
{
    public class BankAccount
    {
        // public object padlock = new object();
        private int balance;
        public int Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public void Deposit(int amount)
        {
            // lock (padlock)
            // {
            //     Balance += amount;
            // }
            // Interlocked approach
            Interlocked.Add(ref balance, amount);
        }

        public void Withdraw(int amount)
        {
            // lock (padlock)
            // {
            //     Balance -= amount;
            // }
            // Interlocked approach
            Interlocked.Add(ref balance, -amount);
        }
    }
}
