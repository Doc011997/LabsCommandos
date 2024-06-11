// Reptile class deriving from Animal
public class Reptile : Animal
{
    public Reptile(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"Reptile {Name} is moving.");
    }

    public override void Eat()
    {
        Console.WriteLine($"Reptile {Name} is eating.");
    }

    public virtual void LayEggs()
    {
        Console.WriteLine($"Reptile {Name} is laying eggs.");
    }
}