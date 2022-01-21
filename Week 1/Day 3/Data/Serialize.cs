using System.Text.Json;
using InventoryFunction;

namespace SerializationFunction{
    public class Serialization{
        private string _filepath = "./Database/AnimalInventory.json";

        public void save(string item){
            string jsonString = JsonSerializer.Serialize(item, new JsonSerializerOptions {Write Indented = true});
            Console.WriteLine(jsonString);
            File.WriteAllText(_filepath,jsonString);
        }


        File.WriteAllText(_filepath, jsonString);
    }
}