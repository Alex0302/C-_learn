namespace Logger;

public class FileLogger : Ilogger
{
    public void Log(string message)
    {
        // Console.WriteLine();
        File.AppendAllText("data.log", $"{DateTime.Now} {message}\n");
    }
}