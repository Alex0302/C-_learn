// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DateTime dt1 = new DateTime(2030,12,4,19,12,33);
DateTime dt2 = new DateTime(2030,12,5,19,12,33);

TimeSpan sub = dt2 - dt1;

System.Console.WriteLine(sub.TotalMinutes);

int n = 5000;

int[,] a = new int[n,n];
int s = 0;

DateTime start = DateTime.Now;

for(int i = 0; i < a.GetLength(0); i++)
{
    for(int j = 0; j < a.GetLength(1); j++)
    {
        s += a[j,i];
    }
}

DateTime end = DateTime.Now;

TimeSpan sub2 = end - start;

System.Console.WriteLine(sub2.TotalMilliseconds);