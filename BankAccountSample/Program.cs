using BankAccountSample.Methodologies.Wrong;

namespace BankAccountSamples
{
    public static class Program
    {
        public static void Main()
        {
            var tasks = new List<Task>();
            AbstractBalance ba = new BankAccountWrongBalance();
            ba.CalculateBalance(tasks, ba);

            ba = new BankAccountPadlock();
            ba.CalculateBalance(tasks, ba);

            ba = new BankAccountInterlocked();
            ba.CalculateBalance(tasks, ba);
        }
    }
}
