using System;
using Newtonsoft.Json; //dotnet add package Newtonsoft.Json

public class WeatherForecast
{
    public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string Summary { get; set; }
}

public class Program
{
    public static void Main()
    {
        string jsonString = "{\"Date\":\"2019-08-01T00:00:00-07:00\",\"TemperatureCelsius\":25,\"Summary\":\"Hot\"}";
        WeatherForecast weatherForecast = JsonConvert.DeserializeObject<WeatherForecast>(jsonString);

        Console.WriteLine($"Date: {weatherForecast.Date}");
        Console.WriteLine($"Temperature: {weatherForecast.TemperatureCelsius}°C");
        Console.WriteLine($"Summary: {weatherForecast.Summary}");
    }
}
