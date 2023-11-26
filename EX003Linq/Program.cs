namespace Ex003Linq;



public partial class Program
{   

    static void Main(string[] arg)
    {
        MathCalc calc = new();

        MathAction method = calc.Sum;
        Console.WriteLine(method(1, 2));


        int result = Calculate(20, 10, (int x, int y) => x + y);

        Console.WriteLine(result);

        result = Calculate(20, 10, (int x, int y) =>
    {
        return x - y;
    });

        Console.WriteLine(result);

        result = Calculate(20, 10, delegate (int x, int y)
    {
        return x / y;
    });

        Console.WriteLine(result);

    }


}



