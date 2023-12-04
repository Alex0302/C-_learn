using System.Reflection;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        WeatherForecast wf = new WeatherForecast(
            date: DateOnly.FromDateTime(DateTime.Now.AddDays(1)),
            temperatureC: 20,
            summary: "Hot"
        );
        // wf.TemperatureC = 123;
        wf.GetString().Print();

        FieldInfo[] fieldsInfos = typeof(WeatherForecast).GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var field in fieldsInfos)
        {
            field.FieldType.Name.Print();
        }

        wf.GetString().Print();
    }
}

public class WeatherForecast
{
    private DateOnly date;
    private int temperatureC;
    private string summary;

  public WeatherForecast(DateOnly date, int temperatureC, string summary)
  {
    this.date = date;
    this.temperatureC = temperatureC;
    this.summary = summary;
  }  
  public DateOnly Date { get => date; private set => date = value; }
  public int TemperatureC { get => temperatureC; private set => temperatureC = value; }
  public string Summary { get => summary; private set => summary = value; }
  public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

static class WeatherForecastPrinter
{
    public static string GetString(this WeatherForecast model)
    {
        StringBuilder sb = new StringBuilder();
        sb.Append($"Date: {model.Date}\n");
        sb.Append($"Summary: {model.Summary}\n");
        sb.Append($"TemperatureC: {model.TemperatureC}\n");
        sb.Append($"TemperatureF: {model.TemperatureF}");

        return sb.ToString();
    }
    public static void Print<T>(this T t)
    {
        Console.WriteLine($"{t}\n");
    }
}