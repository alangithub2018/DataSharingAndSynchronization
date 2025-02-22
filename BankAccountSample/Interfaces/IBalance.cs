public interface IBalance
{
    int Balance { get; }
    public void CalculateBalance(List<Task> tasks, AbstractBalance ba);
}