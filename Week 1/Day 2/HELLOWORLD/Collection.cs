/*
namespace CollectionFunction
{
    public class Collection{
        //Array  
        //Used to store a datatype and have a fixed size
        //Zero-based index
        //Syntax: (datatype) [] (name of variable) = new (datatype)[(size of the array)];
        private int[] _nums = new int[5];
        
        //Generic Collection
        //They store a specific datatype and have vairable size
        //Syntax: <(datatype)>

        // List Collection
        //Zero-based index
        //used to store a datatype and has variable size
        private List<string> _strings = new List<string>();

        //Hashset Collection
        //there is no particular order to the element
        //cannot have duplicate elements
        private HashSet <int> _numsCollection = new HashSet<int>();

        //Dictionary Collection
        //Stores information through key-value pairs
        //There is no particular order
        //There is no particular order
        private Dictionary<string,int> _directory = new Dictionary<string,int>();


        //Non-generic Collection
        //they store any datatype and have variable size

        public class CollectionMain(){
            //Console.WriteLine("===Collection Demo===");
            _nums[0] = 3;
            _nums[1] = 10;
            _nums[2] = 4;

            // A way to go though a list
            // Foreach will iterate though all of the element of a collection/array
            foreach(int item in _nums) {
                Console.WriteLine(num);
            }

            //For loops is for a mroe complex way to iterate through a collection
            for(in i = 0; i < _nums.Length; i+=2){
                Console.WriteLine("Currentvalue of i: " + i);
                Console.WriteLine(_nums[i]);
            }

            Console.WriteLine("===Generic Collection===");
            Console.WriteLine("=List Demo=");
            _strings.Add("First element");
            _strings.Add("Second element");
            _strings.Add("Third element");

            foreach (string itme in _strings){
                Console.WriteLIne(item);
            }

            Console.WriteLine("=Hashset Demo=");
            _numsCollection.Add(1);
            _numsCollection.Add(2);
            _numsCollection.Add(3);
            _numsCollection.Add(1);

            foreach (int item in _numsCollection){
                Console.WriteLine(item);
            }
            //Console.WriteLine(_numsCollection[1]); -- gives and exception due to hashsheet being zero-based index

            Console.WriteLine("=Dictionary Demo=");
            _directory.Add("Stephen", -10000);
            _directory.Add("Vijhan", 1000);
            _directory.Add(Jonathon", -100000);
            //_directory.Add("Stephen", 100); --will give an exception due ot Stephen key already existing
            
            //DIctionary uses key to ook up information from its stored data
            Console.WriteLine(_directory["Stephen"[]);
            COnsole.WriteLIne(_directory["Jonathon"]);
        }


        
    }
}

*/