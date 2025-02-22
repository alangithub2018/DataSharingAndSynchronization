public abstract class AbstractBalance : IBalance
{
    public virtual int Balance { get; protected set; }

    public virtual void CalculateBalance(List<Task> tasks, AbstractBalance ba)
    {
        for (int i = 0; i < 10; i++)
        {
            tasks.Add(Task.Factory.StartNew(() =>
            {
                for (int j = 0; j < 1000; j++)
                {
                    Deposit(100);
                }
            }));

            tasks.Add(Task.Factory.StartNew(() =>
            {
                for (int j = 0; j < 1000; j++)
                {
                    Withdraw(100);
                }
            }));
        }

        Task.WaitAll(tasks.ToArray());
        Console.WriteLine($"Final balance is {Balance}. Calculated using {GetType().Name}");
        Deposit(100);
        Deposit(100);
    }

    public abstract void Deposit(int amount);

    public abstract void Withdraw(int amount);
}