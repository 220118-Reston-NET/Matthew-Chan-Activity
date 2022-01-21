namespace InventoryFunction
{
    public class Inventory{
        private int _totalCapacity;
        private int _currentCapacity = 0;
        private Dictionary<string,int> _ownedAnimals = new Dictionary<string,int>();

        public Inventory(int capacity){
            _totalCapacity = capacity;
            Console.WriteLine("new zoo created");
        }

        public void SetAnimals(String animal){
                int currentCount;
                _ownedAnimals.TryGetValue(animal, out currentCount); 
                _ownedAnimals[animal] = currentCount + 1;
                _currentCapacity++;
        }

        public String[] GetAnimals(){
            String[] listOfAnimals = new String[_currentCapacity];
            int count = 0;
            foreach (string key in _ownedAnimals.Keys){  
                listOfAnimals[count++] = (key);  
            }  
            return listOfAnimals;
        }

        public int TotalCapacity { get; set; }

        public bool IfFull(){
            if(_currentCapacity == _totalCapacity){return true;}
            else{ return false;}
        }

        public void RemoveAnimal(String animal){
            if(_ownedAnimals.ContainsKey(animal)){
                _ownedAnimals.Remove(animal);
                Console.WriteLine(animal + " is removed.");
                _currentCapacity--;
            }
            else{
                Console.WriteLine(animal + " does not exist in this zoo");
            }
        }

        public String ConvertToJSON(){
            return JsonConvert.SerializeObject( _ownedAnimals );
        }
    }


}
