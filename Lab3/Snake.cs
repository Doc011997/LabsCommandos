public class Snake : IReptile
{
    public string Name { get; private set; }

    public Snake(string name)
    {
        Name = name;
    }

    public void Move()
    {
        Console.WriteLine("The snake slithers.");
    }

    public void Eat()
    {
        Console.WriteLine("The snake eats a mouse.");
    }

    public void ShedSkin()
    {
        Console.WriteLine("The snake sheds its skin.");
    }
}

