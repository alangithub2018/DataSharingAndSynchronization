public interface IBalance
{
    int Balance { get; }
    void CalculateBalance(List<Task> tasks, AbstractBalance ba);
}