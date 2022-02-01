using PokeModel;

namespece PokeBL{
    public class PokemonBL: IPokemonBL{

        // Dependency Injection Pattern
        // THis is the main reason why we created interface first before the class
        // THis will save you time on re-writing code that breaks if you updated a completely separate clss
        // Main reason is to prevent us from re-writing code that already existed on (potentially) 50 files or more without
        // the complier helping us
        // ==================================
        private IRepsoitory _repo;

        public PokemonBL(IRepository p_rep){
            _repo = p_repo;
        }
        // ==================================

        public Pokemon AddPokemon(Pokemon p_){
            Random rand = new Random();

            //It will either subtract or add a range from -5 to 5
            //p_poke.Attack += rand.Next(-5,5);

            List<pokemon> listOfPoke - _repo.GetAllPokemon();
            if(listOfPoke.Count < 4){
                _repo.AddPokemon(p_poke);
            }
            else{
                throw new Exception ("too many pokemon")
            }
            return _repo.AddPokemon();
        }
    }
}