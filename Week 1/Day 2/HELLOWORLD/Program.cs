// See https://aka.ms/new-console-template for more information
using CarFunction;

Console.WriteLine("Hello, World!");

//NameOfClass NameofVariable = new NameofClass();
Car car1 = new Car();

Console.WriteLine(car1.Color);
car1.Color = Red
Console.WriteLine(car1.Color);
car1.Fuel = 10;
Console.WriteLine(car1.Fuel);
car1.start();
car1.Start(100);

//Another way of initializing objects out of a class but preconfiguring our states already
Car car2 = new Car()
{
    Color = "Yellow",
    Fuel = 1000,
    Owner = "John";
};

Console.WriteLine(car2.Color);
Console.WriteLine(car2.TotalDistance);

// Console.WriteLine(car2.Color);

repeat = True;
while(repeat == True)
    Console.WriteLine("Welcome to programming!");
    Console.WriteLine("Please tell me your name");
    //Console.ReadlLine
    String userInput = Console.ReadLine();
    Console.WriteLine($"Hello {userInput}, what do you want to do today?");
    Console.WriteLine("[1] 0 Add two numbers");
    Console.WriteLine("[2] - Exit");

    string userInput = Console.ReadLine();

    if(userInput == "1"){
        Console.WriteLine("Please give me 2 numbers");
        //Convert class is designed for us to convert datatypes into another datatype
        //It isn't perfect
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WritLine($"The sum is: {num2 + num1}");
        Console.WriteLine("Please press Enter to continue");
        COnsole.ReadLine();
    }
    else if(userInput == "2"){
        repeat = false;
    }
