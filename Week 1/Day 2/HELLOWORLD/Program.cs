// See https://aka.ms/new-console-template for more information


//using CarFunction;
//using CollectionFunction;
using ConversionFunction;

/*
Console.WriteLine("Hello, World!");

//NameOfClass NameofVariable = new NameofClass();
Car car1 = new Car();

Console.WriteLine(car1.Color);
car1.Color = "Red";
Console.WriteLine(car1.Color);
car1.Fuel = 10;
Console.WriteLine(car1.Fuel);
car1.Start();
car1.Start(100);

//Another way of initializing objects out of a class but preconfiguring our states already
Car car2 = new Car()
{
    Color = "Yellow",
    Fuel = 1000,
    Owner = "John"
};

Console.WriteLine(car2.Color);
Console.WriteLine(car2.TotalDistance); /////////////asjdklf;jskldfjk

Console.WriteLine(car2.Color);


bool repeat = true;

Console.WriteLine("Welcome to programming!");
Console.WriteLine("Please tell me your name");
String nameInput = Console.ReadLine();
while(repeat == true){

    Console.WriteLine($"Hello {nameInput}, what do you want to do today?");
    Console.WriteLine("[1] - Add two numbers");
    Console.WriteLine("[2] - Exit");

    string userInput = Console.ReadLine();

    if(userInput == "1"){
        Console.WriteLine("Please give me 2 numbers");
        //Convert class is designed for us to convert datatypes into another datatype
        //It isn't perfect
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The sum is: {num2 + num1}");
        Console.WriteLine("Please press Enter to continue");
        Console.ReadLine();
    }
    else if(userInput == "2"){
        repeat = false;
    }
}
*/

/*
Collection collect = new Collection();
collect.CollectionMain();
*/

Conversion convert = new Conversion();
convert.ConversionMain();