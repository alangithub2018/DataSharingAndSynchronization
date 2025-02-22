using BankAccountSample.Methodologies.Wrong;

namespace BankAccountSamples
{
    public static class Program
    {
        public static async Task Main()
        {
            await RunCalculationsAsync(new BankAccountWrongBalance());
            await RunCalculationsAsync(new BankAccountPadlock());
            await RunCalculationsAsync(new BankAccountInterlocked());
        }

        private static async Task RunCalculationsAsync(AbstractBalance account)
        {
            var tasks = new List<Task>();
            account.CalculateBalance(tasks, account);
            await Task.WhenAll(tasks);
            Console.WriteLine($"Final Balance for: {account.GetType().Name} is {account.Balance}");
        }
    }
}
