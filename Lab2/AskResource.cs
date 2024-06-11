using System;
using System.Collections.Generic;
using System.Threading;
public class AskResource
{
    private List<SystemResource> resources;

    public AskResource()
    {
        resources = new List<SystemResource>();
    }

    // Method to acquire resources
    public void AcquireResource(SystemResource resource, int time)
    {
        Console.WriteLine($"Requesting {resource.Name} for {time} seconds");
        Thread.Sleep(time * 1000); // Simulate resource usage
        Console.WriteLine($"{resource.Name} acquired for {time} seconds");
    }

    // Method to free resources
    public void FreeResource(SystemResource resource)
    {
        Console.WriteLine($"Releasing {resource.Name}");
    }

    // Method to execute the resource requests
    public void Execute()
    {
        foreach (SystemResource resource in resources)
        {
            AcquireResource(resource, 5); // Simulating usage for 5 seconds
            FreeResource(resource);
        }
    }

    // Method to add required resources and their timing
    public void AddResource(SystemResource resource)
    {
        resources.Add(resource);
    }
}
