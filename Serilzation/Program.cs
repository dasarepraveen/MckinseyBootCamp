using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;



namespace Serilzation
{
    [Serializable]
  public  class Tutorial
    {
        public int Id;
        public string Name;
        

    }
    
[Serializable]
public class WeatherForecast
{
    //public DateTimeOffset Date { get; set; }
    public int TemperatureCelsius { get; set; }
    public string Summary { get; set; }

    
}


    

   
    class Program
    {
        static void Main(string[] args)
        {
             Tutorial objx = new Tutorial();

            objx.Id=10;
            objx.Name="Example";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"Users\praveenkumar_dasare\Documents\dot-net-projects\myfirstproject\src\Serilzation\ExampleNew.txt",
            FileMode.Create,FileAccess.Write);

            formatter.Serialize(stream, objx);
            stream.Close();


            stream = new FileStream(@"Users\praveenkumar_dasare\Documents\dot-net-projects\myfirstproject\src\Serilzation\ExampleNew.txt"
            ,FileMode.Open,FileAccess.Read);
            Tutorial objnew = (Tutorial)formatter.Deserialize(stream);

            Console.WriteLine(objnew.Id);
            Console.WriteLine(objnew.Name);

            Console.ReadKey();




        //Json serializer
        //  WeatherForecast wf = new WeatherForecast();
        //    wf.TemperatureCelsius=35;
        //    wf.Summary="Hot";
            
           
        //     string jsonString;
        //     jsonString = JsonSerializer.Serialize(wf);

        //     File.WriteAllText(@"Users\praveenkumar_dasare\Documents\dot-net-projects\myfirstproject\src\Serilzation\Exampe.json", jsonString);

        //     byte[] jsonUtf8Bytes;
        //     var options = new JsonSerializerOptions
        //     {
        //      WriteIndented = true
        //     };
        //     jsonUtf8Bytes = JsonSerializer.SerializeToUtf8Bytes(wf, options);

        //     var utf8Reader = new Utf8JsonReader(jsonUtf8Bytes);
        //     wf = JsonSerializer.Deserialize<WeatherForecast>(ref utf8Reader);
        //     Console.WriteLine("hmmm: {0}",wf);

            //JsonSerializer.Deserialize(jsonString);

        //     var options = new JsonSerializerOptions
        // {
        //      IgnoreNullValues = true
        // };
       // wf = JsonSerializer.Deserialize(jsonString, options);
           
          // File.WriteAllText(fileName, jsonString);



           

            //JsonReaderWriterFactory js = new JsonReaderWriterFactory();

    
    //   DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Spell));
    //  MemoryStream ms = new MemoryStream();
    //  js.WriteObject(ms, frostShock);
    //  Console.WriteLine("\r\nUdemy.com - Serializing and Deserializing JSON in C#\r\n");
    //  ms.Position = 0;
    //  StreamReader sr = new StreamReader(ms);
    //  Console.WriteLine(sr.ReadToEnd());
    //  sr.Close();
    //  ms.Close();
     
      
            

            

            
        }

        
    }
}
