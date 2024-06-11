public class PrimeReceiver
{
    // Method to be executed when a prime event is raised
    public void Action(object sender, PrimeEventArgs pe)
    {
        Console.WriteLine($"Received prime number: {pe.Prime}");
    }
}