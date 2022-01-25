public class OOP{
    public static void OOPMain()
    {
        consolde.WriteLine("===Inheritance Demo---");
        Dog dog1 = new Dog();
        dog1.Talk();
        dog1.Talk("German Shepard");
        Console.WriteLine(dog1.Name);




    }
}

public class Animal{
    public string Name{get; set;}
    public string Color{get;set;}

    public void Talk(){
        Console.WriteLIne("Animal is talking!");
    }

    //method overloading
    //when 2 methods have the same name but diff paramters and implimentation detalis
    //only works with parameters
    public void Talk(string p_talk){

    }
    public Animal(){
        Name = "Animal";
        Color = "Navy Blue";

    }
    public Animal(string p_name){
        Name = p_name;
        Color = "Navy Blue";
    }
}

//Inheritance is denoted by a ":" syntax
//Derived/child class
//COnstructior is a bit special that they aren't inherited by the default base class ???
public class Dog : Animal{
    public Dog():base(){

    }
    public Dog(string p_name): base(){

    }

    // Method Overriding
    // It is whe a derived class changes hte fucntion/implementation detail of hte base class
    // It NEEDS  to use virtual and override keywords(non-access modifiers) to tell the complier 
    // that we are tyring to achinve method overrideing

    public override void Talk(){
        Console.WriteLine("Barking!");
    }
}