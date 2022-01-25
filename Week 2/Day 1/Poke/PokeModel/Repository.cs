using PokeModel;

namespace PokeDL{
    public class Repository : IRepository{
        //Relative filepath is from the PokeUI isnce that is the starting point of our application
        private string _filepath = "../PokeDL/Database/"; // cause our main method is in pokeUI
        private string _jsonString;

        public Pokemon AddPokemon(Pokemon p_poke)
        {
            //So we can change which JSOn files we can pick on other methods
            string path = _filepath + "Pokemon.json";
            
            _jsonString = JsonSerializer.Serialize(p_poke);

            File.WriteAllText(path , _jsonString);

            return p_poke;
        }
    }
}