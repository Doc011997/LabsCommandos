/*using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class Zoo
{
    private List<Animal> animals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        animals.Add(animal);
    }

    public void WalkAll()
    {
        foreach (var animal in animals)
        {
            animal.Move();
        }
    }

    public void FeedAll()
    {
        foreach (var animal in animals)
        {
            animal.Eat();
        }
    }

    public void Serialize(string filePath)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        var jsonString = JsonSerializer.Serialize(animals, options);
        File.WriteAllText(filePath, jsonString);
    }

    public void Deserialize(string filePath)
    {
        var jsonString = File.ReadAllText(filePath);
        animals = JsonSerializer.Deserialize<List<Animal>>(jsonString);
    }
}
*/