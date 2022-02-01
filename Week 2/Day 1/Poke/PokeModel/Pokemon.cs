namespace PokeModel;
public class Pokemon
{
    public int Name {get; set;}
    public int Level { get; set; }

    public int Attack { get; set;}

    public int Defense {get; set;}

    public int Health {get; set;}

    private List<Moves> _moves;

    public List<Moves> Moves {
        get {return _moves;}
        set{
            if (value.Count < 4){
                _moves = value;
            }
            else{
                throw new Exception("Pokemon cannot hold more than 4 abilties");
            }
        }
    }

    public Pokemon(){
        Name = "Ditto";
        Level = 1;
        Attack = 55;
        Defense = 55;
        Health = 55;
        _moves = new List<Moves>(){
            new Moves()
        };
    }

    public override string ToString(){
        return $"Name: {Name}\nLevel: {Level}\nAttack: {Attack}\nDefense: {Defense}\nHealth: {Health}";
    }


}
