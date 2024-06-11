// Mammal class deriving from Animal
public class Mammal : Animal
{
    public Mammal(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"Mammal {Name} is moving.");
    }

    public override void Eat()
    {
        Console.WriteLine($"Mammal {Name} is eating.");
    }

    public virtual void Nurse()
    {
        Console.WriteLine($"Mammal {Name} is nursing its young.");
    }
}