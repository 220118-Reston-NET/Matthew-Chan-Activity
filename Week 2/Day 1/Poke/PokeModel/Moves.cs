namespace PokeModel;
public class Moves{
    private string Name {get; set;}
    private int _PP;
    
    public int PP{
        get { return _PP; }
        //You can only set PP above 0
        set 
        {
            if (value > 0)
            {
                _PP = value; 
            }
            else
            {
                throw new Exception("You cannot set PP lower than 0!");
            }
        }
    } 

    public int Power { get; set; }
    public int Accuracy { get; set; }

    public Ability(){
        Name = "Tackle";
        PP = 40;
        Power = 40;
        Accuracy = 80;
    }
}