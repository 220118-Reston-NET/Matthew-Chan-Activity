// See https://aka.ms/new-console-template for more information
using PokeUI;

bool repeat = true;
IMenu menu = new MainMenu();

// Ability ab = new Ability();
// ab.PP = -1; //Validation is working since can't input a negative value

while(repeat){
    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans){
        case "AddPokemon":
            menu = new AddPokeMenu();
            break;
        case "MainMenu":
            menu = newMainMenu();
            break;
        case "Exit":
            repeat = false;
        default:
            Console.WriteLine("Page does not exist!");
            break;
    }
}
