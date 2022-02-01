public class MoreConversion{
    public static void MoreConvMain(){
        Console.WriteLIne("===More Conversion===")
        int integerVar = 10;
        double doubleVar = integerVar;

        //user defined implicit conversion
        Car car1 = integerVar;
        Console.WriteLine(car1.Fuel);

        //user-defined explicit conversion
        car car2 = (Car)doubleVar;
        Console.WriteLine(car2.Fuel);
    }
}

public class Car{
    public string Owner {get; set;}
    public in Fuel { get; set;}
    //user-defined conversion
    //allows us to create a cless to be able to convert from some other datatype
    //the parameter will dictate what dataype you are converting
    // return an object out of the class
    //Implicit and explicit are interchangeable

    public static implicit operator Car(int p_fuel){
        //
        return new Car(){
            Fuel = p_fuel
        };
    }
}