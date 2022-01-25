using PokeModel;

namespace PokeUI
{
    public class AddPokeMenu: IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddMenu
        private static Pokemon _newPoke = new Pokemon();
        public void Display(){
            Console.WriteLine("Enter Pokemon information");
            Console.WriteLine("[3] Name -" + _newPoke.Name);
            Console.WriteLine("[2] Level -"+ _newPoke.Level);
            Console.WriteLine("[1] Save");
            Console.WriteLine("[0] Go Back")
        }
        public string UserChoice(){
            string userInput = Console.ReadLine();
            switch(userInput){
                case "0":
                    return "Mainmenu";
                case "1":
                    return "MainMenu";
                case "2":
                    return "AddPokemon";
                case "3":
                    Console.WriteLine("Please enter a name!");
                    _newPoke.Name = Console.ReadLine();
                    return "AddPokemon";
                default:
                    Console.WriteLine("PLease input a valid response")_;
                    Console.WriteLine("Please press Enter ot continue")_;
                    Console.ReadLine();
                    return "AddPokemon";
            }
        }
    }
}