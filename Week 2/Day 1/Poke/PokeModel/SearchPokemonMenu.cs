namepace PokeUI{
    pulbic class SearchPokemonMenu :Imenu{
        private IPokemonBL _pokeBL;

        public void Dispaly(){
            Console.WriteLine("Please select an option to filter the pokemon database:");
            COnsole.WriteLine("[1] By Name");
            Console.WriteLine("[0] Exit");
        }
        public string Userchoice()
        string userInput = Console.ReadLine();

        Switch (userInput){
            case 0:
                return "MainMenu";
            case "1":
                Console.WriteLine("Please enter a name");
                string name = Console.ReadLine();
                List<Pokemon> listOfPoke_pokeBL.SearchPokemon(name);

                foreach (var item in listOfPoke){
                    Console.WriteLIne(item);
                }
                Console.WriteLine("Please press ENter to continu")
                Console.ReadLine();

                return "MainMenu";
            default:
            Console.WriteLine("Please enter a valid response");
            Console.WriteLine("Please press Enter to Continue");
            Console.ReadLine();
            return "SearchPokemon";
        }
    }
}