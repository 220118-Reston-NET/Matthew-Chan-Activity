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

        public void Delete(){
            Console.WriteLine("Which item would you like to delete: ");
            string item = Console.ReadLine();
            for(int i = 0; ; < _ownedAnimals.Length; i++){
                if ( _ownedAnimals[])
            }
        }
    }
    
}