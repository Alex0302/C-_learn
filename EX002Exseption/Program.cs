using System.Text;

string str = "string";

// if (str.Length >= 11)
// {
//     char symbol = str[10];
//     Console.WriteLine(symbol);
// }
// else
// {
//  Console.WriteLine("Индекса нет");   
// }
StringBuilder sb = null;
try
{
   char symbol = str[2];
   
   sb.Append(symbol);

   Console.WriteLine(symbol);
}

catch(IndexOutOfRangeException e)
{
    Console.WriteLine($"Ошибка индекса");   
}

catch (Exception ex)
{
  Console.WriteLine($"Ошибка {ex.GetType()}");   
}


finally
{
  Console.WriteLine("+");  
}
