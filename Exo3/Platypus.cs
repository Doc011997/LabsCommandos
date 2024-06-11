// Platypus class deriving from Mammal
public class Platypus : Mammal
{
    public Platypus(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the platypus is swimming.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the platypus is eating.");
    }

    public override void Nurse()
    {
        Console.WriteLine($"{Name} the platypus is nursing its young.");
    }
}
