using System.Text.Json;
using CarFunction;

namespace SerializationFunction{
    /*
        -serialization is the process of converting your C# objects into a JSON file or 110001101 (stream of bypes) or other formats
        -We will be using JSON because it is the most commonly used filre format when comes to transfering/sotring data
        -Main reason why is because collection memory is tmeporary and you might need to save that data later on to be used
        */
    
    public class Serialization{
        //Ther period on hte file path means to auto put the entier firlepath of where this current file is at in your hard drive
        private string _filepath = "./Database/Car.json";
        public static void SerialMain()
        {
            Console WriteLine("===Serilization Demo===");

            //created a list of cars
            List<Car> listOfCars = new List<Car>();
            Car car1 = new Car(){
                Color = "Silver",
                Fuel = 50,
                Owner = "Matt"
            };
        }
        
        //Added car1 twice inside of our list of cars
        listOfCars.Add(car1);

        //Converting C$ object into a JSON formatted string datatype
        //Just means converting C## object into a string
        string jsonString = JsonSerializer.Serialize(car1, new JsonSerializerOptions {Write Indented = true});
        Console.WriteLine(jsonString);
        
        //File class will creatse a JSON file (if there is n't one already) or overwrite
        File.WriteAllText(_filepath, jsonString);

        Console.WriteLine("=Converting JSON to object=");

        
        string jsonString2 = File.ReadAllTest(_filepath);

         car car2 = Json serializer.Deserialize<List<Car>>(jsonString2;
         
         Console.WriteLine(car2[0].Color);
         Console.WriteLine(car2[0].Fuel);
         Console.WriteLine(car2[0].Owner);
    }

    catch (FileNotFoundException)
    {
        COnsole.WritelLine("Flien not found. Creating a new file for you!");
        //Creates a file if a file was not found
        List<Car> 

        jsonString3 = File.ReadAllTesxt(_filepath);

        //JosonSerilaizer
        List<car> car2 = JsonSerializer.Deserialize<List<Car>>(jsonString3);

        Console.WriteLIne(car2)
    }
    catch (System.Exception)
    {
        
        throw;
    }
}