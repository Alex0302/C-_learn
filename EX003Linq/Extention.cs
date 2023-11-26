
static class Extention
{
    public static string[] GetArrayFileNumbers(this string path)
    {
        using StreamReader sr = new StreamReader(path);
        List<string> col = new();

        while (!sr.EndOfStream)
        {
            col.Add(sr.ReadLine());
        }

        return col.ToArray();
    }

  public static int[] ConvertToInt(this string[] col, Func<string, int> converter)
  {
    List<int> numbers = new();

    foreach (var item in col)
    {
      numbers.Add(converter(item));
    }

    return numbers.ToArray();
  }

        public static int[] IfCheck(this int[] col, Func<int, bool> check)
    {
        
        List<int> numbers = new();

        foreach (var item in col)
        {
           if (check(item)) numbers.Add(item);
        }

        return numbers.ToArray();
    }

      public static double Sum(this int[] col)
  {
    double res = 0;

    foreach (var item in col)
    {
      res += item;
    }

    return res;
  }

    public static void Print<T>(this T value)
  {
    Console.WriteLine(value);
  }

}