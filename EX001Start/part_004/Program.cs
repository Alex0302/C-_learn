// class Program 
// {
//     public static void Main()
//     {
//         // See https://aka.ms/new-console-template for more information
//         Console.Write("Сколько элементов массива нужно: ");

//         int count = int.Parse(Console.ReadLine());
        
//         int[] array = new int[count];

//         int index = 0;

//         while (index < count)
//         {
//             array[index] = Random.Shared.Next(0, 10);
//             Console.Write($"{array[index]} ");
//             index++;
//         }

//     }

// }


int GetValueByUserFromTerminal(string text)
{
    Console.Write(text);
    // int value = bool.Parse(Console.ReadLine());
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
 //   
}

int[] CreateArray (int size)
{
    int[] array = new int[size];
    
    return array;
}

void PrintToTerminal(int[] array)
{
    int count = array.Length;
    
    for(int i =0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string Join(char separator, int[] array)
{
    int count = array.Length;
    string result = String.Empty;

    for(int i =0; i < count; i++)
    {
       result += $"{array[i]}{separator}";
    }
    return result;
}

int[] FillOld(int[] array, int min, int max)
{
    int count = array.Length;
    int[] temp = new int[count];

    for(int i =0; i < count; i++)
    {
       temp[i] = Random.Shared.Next(min, max);
        Console.WriteLine(temp[i]);
    }
    return temp;
}

void Fill(int[] array, int min, int max)
{
    int count = array.Length;
    // int[] temp = new int[count];

    for(int i =0; i < count; i++)
    {
       array[i] = Random.Shared.Next(min, max);
        // Console.WriteLine(temp[i]);
    }
    // return array;
}

void Main()
{
    int size = GetValueByUserFromTerminal("Сколько элементов нужно: ");
    int[] numbers = CreateArray(size);
    string output = Join(' ', numbers);
    Console.WriteLine(output);
    File.WriteAllText("numbers.txt", output);
    Fill(numbers, 0, 10);

    output = Join(' ', numbers);
    Console.WriteLine(output);
    File.WriteAllText("numbers2.txt", output);
}

Main();