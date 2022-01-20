namespace InventoryFunction
{
    public class Inventory{
        private int _totalCapacity;
        private int _currentCapacity = 0;
        public Dictionary<string,int> _ownedAnimals = new Dictionary<string,int>();

        public Inventory(int capacity){
            _totalCapacity = capacity;
            Console.WriteLine("new zoo created");
        }

        public String[] Animals{ 
            get{
                String[] listOfAnimals = new String[_currentCapacity];
                int count = 0;
                foreach (string key in _ownedAnimals.Keys)
                {  
                    listOfAnimals[count++] = (key);  
                }  
                return listOfAnimals; 
            }

            set{
                int currentCount;
                _ownedAnimals.TryGetValue(value[0], out currentCount); 
                _ownedAnimals[value[0]] = currentCount + 1;
                _currentCapacity++;
            } 
            
            
        }
        public int TotalCapacity { get; set; }

        public bool ifFull(){
            if(_currentCapacity == _totalCapacity){return true;}
            else{ return false;}
        }

        public void removeAnimal(String animal){
            if(_ownedAnimals.ContainsKey(animal)){
                _ownedAnimals.Remove(animal);
                Console.WriteLine(animal + " is removed.");
                _currentCapacity--;
            }
            else{
                Console.WriteLine(animal + " does not exist in this zoo");
            }
        }
    }


}
