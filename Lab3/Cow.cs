public class Cow : IMammal
{
    public string Name { get; private set; }

    public Cow(string name)
    {
        Name = name;
    }

    public void Move()
    {
        Console.WriteLine("The cow walks slowly.");
    }

    public void Eat()
    {
        Console.WriteLine("The cow eats grass.");
    }

    public void Nurse()
    {
        Console.WriteLine("The cow nurses her calf.");
    }
}