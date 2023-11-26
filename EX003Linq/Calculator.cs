namespace Ex003Linq;

public partial class Program
{
    public static int Calculate(int value1, int value2, MathAction action)
    {
        Console.WriteLine(action.Method.Name);
        Console.WriteLine($"value1: {value1}");
        Console.WriteLine($"value2: {value2}");
        return action(value1, value2);
    }
}
