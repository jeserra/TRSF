using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using System.IO;

using static System.Console;
namespace sample31
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WriteLine(" ==== Serialize Json ");
            var resultJson = SerializaJson();
            WriteLine(resultJson);
            WriteLine(" === Deserialize Json ");
            var weatherForecast =  DeserializeJson(resultJson);
            WriteLine($"{weatherForecast.Date} {weatherForecast.TemperatureCelsius} {weatherForecast.Summary}");
            WriteLine(" ==== Serialize XML "); 
            SerializeXML();
            WriteLine(" ==== Deserialize XML ");
            DeserializeXML();
            ReadLine();

        }
    
        private static WeatherForecast GetWeatherForecast()
        {
                return new WeatherForecast()
                {
                    Date = DateTime.Now,
                    Summary = "Sunny Day",
                    TemperatureCelsius = 24
                };
        }
    
        private static String SerializaJson ()
        {
            return JsonSerializer.Serialize(GetWeatherForecast());
        }

        private static WeatherForecast DeserializeJson (String input)
        {
            return JsonSerializer.Deserialize<WeatherForecast> (input);
        }

        private static void SerializeXML ()
        {
             string filename = @"C:\Users\Lenovo User\Documents\TRSF\sampleserializationxml.xml";
                XmlSerializer x = new XmlSerializer(typeof(WeatherForecast));
                
                using (TextWriter writer = new StreamWriter(filename))
                {
                    x.Serialize(writer, GetWeatherForecast());
                    writer.Close();
                }
                var output = File.ReadAllText(filename);
                WriteLine(output);
        }

        private static void DeserializeXML()
        {
              string filename2 = @"C:\Users\Lenovo User\Documents\TRSF\sampleserializationxml.xml";
                var test = File.ReadAllText(filename2);
                XmlSerializer x = new XmlSerializer(typeof(WeatherForecast));
                // Important: Text Encode must be UTF8
                byte[] byteArray = System.Text.Encoding.UTF8.GetBytes( test );
                MemoryStream stream = new MemoryStream( byteArray );
                var objectnew = (WeatherForecast) x.Deserialize(stream);
                WriteLine($"{objectnew.Date} {objectnew.Summary}  {objectnew.TemperatureCelsius}"); 
        }
    }
}
