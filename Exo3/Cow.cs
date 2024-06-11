public class Cow : Mammal
{
    public Cow(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the cow is moving.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the cow is eating.");
    }

    public override void Nurse()
    {
        Console.WriteLine($"{Name} the cow is nursing its young.");
    }
}