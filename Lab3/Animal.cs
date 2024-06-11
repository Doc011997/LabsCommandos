using System;

public class Animal
{
    public string Name { get; private set; }

    public Animal(string name)
    {
        Name = name;
    }

    public virtual void Move()
    {
        Console.WriteLine("Animal is moving.");
    }

    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

public class Mammal : Animal
{
    public Mammal(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Mammal is moving.");
    }

    public override void Eat()
    {
        Console.WriteLine("Mammal is eating.");
    }

    public void Nurse()
    {
        Console.WriteLine("Mammal is nursing.");
    }
}

public class Reptile : Animal
{
    public Reptile(string name) : base(name)
    {
    }

    public override void Move()
    {
        Console.WriteLine("Reptile is moving.");
    }

    public override void Eat()
    {
        Console.WriteLine("Reptile is eating.");
    }

    public void ShedSkin()
    {
        Console.WriteLine("Reptile is shedding skin.");
    }
}
