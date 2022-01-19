//Namespace is a great way to organize your code
namespace CarFunction
{
    //This is how you create a class by using he class keyword
    //Public is just there to make the class visable for everyone
    public class Car{
        
        //Field
        //It is used to store information or define the current state of the object when yiou first make it
        //private means that only the class itslef can use that field
        private string _color = blue;
        private string _owner;
        private int _fuel;
        private int _gallonPerMile;
        
        //Property
        //THey are in PascalCase
        public string Color{
            set { _color = value; } 
            get { return "The color is: " + _color; }
        }

        public strong _owner{
            get {return _owner;}
            set{ _owner = value;}
        }

        public int Fuel { get; set; }

        //constructors????????
        // it is a special method that will run first whenever you create an object out of that class
        public Car() {
            Console.WriteLine("A car is created!");
            _color = "Blue";
            _gallonPerMile = 10;
            _owner = "No Owner";
            Fuel = 100;
        }


        //a method will run multiple lines of code to do some sort of operation/behavior/function
        //void this method will reutrn/give back nothing
        // we can change void into another datatype if you want the method to give information back
        public void Start(){
            Console.WriteLine("THe car is starting right now!");
            Console.WriteLine($"Current fuel: {Fuel}");
        }

        //you can add parapeters to a method to pass in data to be used inside method
        // make sure the parameter has a datatype and then a name
        public void start(int p_fuel){
            Fuel = p_fuel;
            Console.WriteLine("THe car is starting right now!");
            Console.WriteLine($"Current fuel: {Fuel}");
        }

        //Will give the total distance of the car
        //Methods can return data back if you didn't put void
        public double TotalDistance(){
            return (double)Fuel/ _gallonPerMile;
        }
        
    }
}
