public class Lizard : IReptile
{
    public string Name { get; private set; }

    public Lizard(string name)
    {
        Name = name;
    }

    public void Move()
    {
        Console.WriteLine("The lizard scurries.");
    }

    public void ShedSkin()
    {
        Console.WriteLine("The lizard sheds its skin.");
    }

    public void Eat()
    {
        throw new NotImplementedException();
    }
}

