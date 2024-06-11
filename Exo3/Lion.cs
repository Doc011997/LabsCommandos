public class Lion : Mammal
{
    public Lion(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the lion is moving.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the lion is eating.");
    }

    public override void Nurse()
    {
        Console.WriteLine($"{Name} the lion is nursing its young.");
    }
}