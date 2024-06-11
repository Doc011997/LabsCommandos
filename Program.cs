using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        /*X obj1, obj2;
        obj1 = new X();
        obj2 = new X();
        Console.WriteLine(obj1);
        Console.WriteLine(obj2); */

        //exercice3//

        // Crée une instance de Trumpet et appelle la méthode Play
        //new Trumpet().Play();
        // pause if needed */

        //Exercice4//
        // Create and start 5 threads
        /*for (int i = 0; i < 5; i++)
        {
            char letter = (char)('A' + i); // Calculate the letter to display
            Thread t = new Thread(() => DisplayLetter(letter)); // Create a thread for each letter
            t.Start();
        }
    }

    static void DisplayLetter(char letter)
    {
        while (true) // Infinite loop
        {
            Console.WriteLine(letter); // Display the letter
            Thread.Sleep(9000); // Pause for 1 second
        }
    }
} */

        /*
                // Create instances of PrimeReceiver and PrimeSender
                PrimeReceiver receiver = new PrimeReceiver();
                PrimeSender sender = new PrimeSender();

                // Subscribe the receiver's Action method to the sender's PrimeEvent
                sender.PrimeEvent += receiver.Action;

                // Calculate primes up to a limit and raise the PrimeEvent
                sender.CalculatePrimes(100);
            }
        }
        */

        // Create system resources
        SystemResource printer = new SystemResource("Printer");
        SystemResource ram = new SystemResource("RAM");
        SystemResource disk = new SystemResource("Disk");

        // Create ask resources
        AskResource process1 = new AskResource();
        process1.AddResource(disk);
        process1.AddResource(ram);

        AskResource process2 = new AskResource();
        process2.AddResource(printer);
        process2.AddResource(ram);

        // Execute ask resources
        Console.WriteLine("Executing Process 1:");
        process1.Execute();

        Console.WriteLine("\nExecuting Process 2:");
        process2.Execute();
    }
}





/*class Program
{
    static int i = 5;

    static void Increment()
    {
        for (int j = 0; j < 1000; j++)
        {
            i++;
        }
    }

    static void Decrement()
    {
        for (int j = 0; j < 1000; j++)
        {
            i--;
        }
    }

    static void Main(string[] args)
    {
        Thread t1 = new Thread(Increment);
        Thread t2 = new Thread(Decrement);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine($"Final value of i: {i}");
    }
}
// T1 : Reg = i (Reg = 5)
// T2 : Reg = i (Reg = 5)
// T1 : sommeil
// T2 : sommeil
// T1 : Reg++ (Reg = 6)
// T2 : Reg-- (Reg = 4)
// T1 : i = Reg (i = 6)
// T2 : i = Reg (i = 4)


using System;
using System.Threading;

class Program
{
    static int i = 5;
    static SemaphoreSlim semaphore = new SemaphoreSlim(1, 1);

    static void Incrementer()
    {
        for (int j = 0; j < 1000; j++)
        {
            semaphore.Wait();
            i++;
            semaphore.Release();
        }
    }

    static void Decrementer()
    {
        for (int j = 0; j < 1000; j++)
        {
            semaphore.Wait();
            i--;
            semaphore.Release();
        }
    }

    static void Main(string[] args)
    {
        Thread t1 = new Thread(Incrementer);
        Thread t2 = new Thread(Decrementer);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.WriteLine($"Valeur finale de i : {i}");
    }
}
*/