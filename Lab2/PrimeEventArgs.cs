using System;

// Define PrimeEventArgs class
public class PrimeEventArgs : EventArgs
{
    private long _prime;

    // Read-only property to access the prime value
    public long Prime
    {
        get { return _prime; }
    }
    public PrimeEventArgs(long p) : base()
    {
        _prime = p;
    }
}
