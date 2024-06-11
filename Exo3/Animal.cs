public class Animal
{
    public string Name { get; private set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Move()
    {
        Console.WriteLine($"Animal {Name} is moving.");
    }

    public virtual void Eat()
    {
        Console.WriteLine($"Animal {Name} is eating.");
    }
}
