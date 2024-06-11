public class Lizard : Reptile
{
    public Lizard(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the lizard is crawling.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the lizard is eating.");
    }

    public override void LayEggs()
    {
        Console.WriteLine($"{Name} the lizard is laying eggs.");
    }
}