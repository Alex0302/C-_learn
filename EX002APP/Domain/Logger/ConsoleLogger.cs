namespace Logger;

public class ConsoleLogger : Ilogger
{
    public void Log(string message)
    {
        Console.WriteLine($"{DateTime.Now} {message}\n");
    }
}