// See https://aka.ms/new-console-template for more information

string message = "Value1: ";
Console.Write(message);
int number1 = int.Parse(Console.ReadLine()); // считывание данных из терминала


message = "Value2: ";
Console.Write(message);
int number2 = int.Parse(Console.ReadLine()); // считывание данных из терминала

int result = number1 + number2;

// Console.WriteLine("Result: " + result);

string output = $"{number1} + {number2} = {result}";

Console.WriteLine(output);