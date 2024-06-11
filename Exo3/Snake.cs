public class Snake : Reptile
{
    public Snake(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine($"{Name} the snake is slithering.");
    }

    public override void Eat()
    {
        Console.WriteLine($"{Name} the snake is eating.");
    }

    public override void LayEggs()
    {
        Console.WriteLine($"{Name} the snake is laying eggs.");
    }
}