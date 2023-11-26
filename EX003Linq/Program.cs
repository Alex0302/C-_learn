namespace Ex003Linq;



public partial class Program
{   

    static void Main(string[] arg)
    {
        MathCalc calc = new();

        MathAction method = calc.Sum;
        Console.WriteLine(method(1, 2));


        int result = Calculate(20, 10, calc.Sum);

        Console.WriteLine(result);

        result = Calculate(20, 10,calc.Sub);

        Console.WriteLine(result);

        result = Calculate(20, 10, calc.Div);

        Console.WriteLine(result);

    }


}



