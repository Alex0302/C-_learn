class Program 
{
    public static void Main()
    {
        // See https://aka.ms/new-console-template for more information
        Console.Write("Сколько элементов массива нужно: ");

        int count = int.Parse(Console.ReadLine());
        
        int[] array = new int[count];

        int index = 0;

        while (index < count)
        {
            array[index] = Random.Shared.Next(0, 10);
            Console.Write($"{array[index]} ");
            index++;
        }

    }

}


