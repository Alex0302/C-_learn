using System.Linq;

namespace Ex003Linq;

public partial class Program
{   

    static void Main(string[] arg)
    {
        
        // У нас есть файл, в файле числа, не больше 10_000
        // каждое число с новой строки
        // требуется считать файл, найти в нем все числа кратные 3 и найти их сумму


      "numbers.txt".GetArrayFileNumbers()
                   .ConvertToInt(int.Parse)
                   .IfCheck(x => x % 3 == 0)
                   .Sum()
                   .Print();
        // Console.WriteLine(String.Join(' ', numbers));

        var res = File
                    .ReadAllLines("numbers.txt")
                    .Select(int.Parse)
                    .Where(x => x % 3 == 0)
                    .Sum();

            Console.WriteLine(res);
    }


}



