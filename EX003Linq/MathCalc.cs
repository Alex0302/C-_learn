namespace Ex003Linq;

public delegate int MathAction(int a, int b);

public class MathCalc
{
    public int Sum(int x, int y)
    {
        return x + y;
    }

    public int Sub(int x, int y)
{
    return x - y;
}

    public int Div(int x, int y)
{

    return x / y;
}
}