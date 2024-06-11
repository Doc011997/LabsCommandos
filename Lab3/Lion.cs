public class Lion : IMammal
{
    public string Name { get; private set; }

    public Lion(string name)
    {
        Name = name;
    }

    public void Move()
    {
        Console.WriteLine("The lion prowls.");
    }

    public void Eat()
    {
        Console.WriteLine("The lion eats meat.");
    }

    public void Nurse()
    {
        Console.WriteLine("The lioness nurses her cubs.");
    }
}
