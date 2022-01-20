namespace ConversionFunction
{
    public class Conversion{
        //Static fields are shared between all objects from this class
        //In this way if you neeed a universal information that needs to be stored and shared to every object from this
        //Use a static field
        public static int _num;
        
        //static methods will make using that method without creating an object
        public static void ConversionMain()
        {
            //Implicit - just means something is done automatically (mostly is the compiler)
            //Explicit - just means you have to write something to do it (essentially tell the compiler to do it anyway)

            Console.WriteLine("==COnversion Demo===");
            int x = 10;
            double y = 85.29;
            char c = 'u';
            string str = "Hello World";
            
            //Implicit covnersion
            //The general rule is if you are going from a datatype to another datatype without loss
            double anotherDouble = x;
            Console.WriteLine(anotherDouble);

            //Explicit conversion
            int anotherInt = (int)y;
            Console.WriteLine(anotherInt);

            //another way of explicit conversion
        }

        public int GiveMeNumber(){
            return _num;
        }

        
    }
}