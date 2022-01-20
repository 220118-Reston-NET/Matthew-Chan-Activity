//dotnet new console -o "NameOfFile"
// See https://aka.ms/new-console-template for more information

bool repeat = true;

while(repeat == true){
    Console.WriteLine("Hello, What would you like to do today?");
    Console.WriteLine("Enter 1 if you want to count from 3 to 7");
    Console.WriteLine("Enter 2 if you want to multiply 2 numbers");
    Console.WriteLine("Enter 3 if you want to add multiple numbers");
    Console.WriteLine("Enter 4 if you want to exit");

    String userInput = Console.ReadLine();
    if(userInput == "1"){
        for(int i=3; i < 8; i++){
            Console.WriteLine(i);
        }
    }
    else if(userInput == "2"){
        Console.WriteLine("Enter Number 1: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Number 2: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The product is: " + (num1 * num2));
    }
    else if(userInput == "3"){
        Console.WriteLine("How many numbers would you like to add?");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for(int i= 1; i <= num; i++){
            Console.WriteLine("Enter Number " + i + ": ");
            sum += Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("The sum is: " + sum);
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
