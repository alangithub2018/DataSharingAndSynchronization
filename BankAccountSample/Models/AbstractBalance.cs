public abstract class AbstractBalance : IBalance
{
    public virtual int Balance { get; protected set; }

    /// <summary>
    /// Calculates the balance by performing multiple deposit and withdraw operations concurrently.
    /// </summary>
    /// <param name="tasks">The list of tasks to add the operations to.</param>
    /// <param name="account">The account to perform the operations on.</param>
    public virtual void CalculateBalance(List<Task> tasks, AbstractBalance account)
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
    }

    public abstract void Deposit(int amount);

    public abstract void Withdraw(int amount);
}