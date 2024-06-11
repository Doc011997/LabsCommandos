public class PrimeSender
{
    // Define the delegate for the prime event
    public delegate void PrimeEventHandler(object sender, PrimeEventArgs e);

    // Define the event based on the delegate
    public event PrimeEventHandler PrimeEvent;

    // Method to calculate prime numbers and raise the prime event
    public void CalculatePrimes(long limit)
    {
        for (long i = 2; i <= limit; i++)
        {
            if (IsPrime(i))
            {
                OnPrimeEvent(i); // Raise the prime event
            }
        }
    }

    // Method to check if a number is prime
    private bool IsPrime(long number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (long i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    // Method to raise the prime event
    protected virtual void OnPrimeEvent(long prime)
    {
        PrimeEvent?.Invoke(this, new PrimeEventArgs(prime));
    }
}
