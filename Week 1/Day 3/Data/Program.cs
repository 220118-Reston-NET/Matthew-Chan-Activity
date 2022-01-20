// See https://aka.ms/new-console-template for more information
using InventoryFunction;

Console.WriteLine("What is the capacity of your zoo?");
int capacity = Convert.ToInt32(Console.ReadLine());
Inventory oakZoo = new Inventory(capacity);


bool repeat = true;

while(repeat == true){
    Console.WriteLine("Hello, What would you like to do to your zoo today?");
    Console.WriteLine("Enter 1 list out your animals");
    Console.WriteLine("Enter 2 if you want to add a unique animal");
    Console.WriteLine("Enter 3 if you want to remove animals");
    Console.WriteLine("Enter 4 if you want to exit");

    String userInput = Console.ReadLine();
    if(userInput == "1"){
        foreach (String item in oakZoo.GetAnimals()){
                Console.WriteLine(item);
        } 

    }
    else if(userInput == "2"){
        Console.WriteLine("How many numbers would you like to add?");
        int num = Convert.ToInt32(Console.ReadLine());
        for(int i= 1; i <= num; i++){
            Console.WriteLine("Enter Animal " + i + ": ");
            oakZoo.SetAnimals(Console.ReadLine());
        }
    }
    else if(userInput == "3"){
        Console.WriteLine("Which animal would you like to remove?");
        oakZoo.RemoveAnimal(Console.ReadLine());

    }
    
    else if(userInput == "4"){
        repeat = false;
    }
    else{
        Console.WriteLine("Error, not a valid input. Please try again.");
    }
    Console.WriteLine("Please press enter to continue.");
    Console.ReadLine();
}

