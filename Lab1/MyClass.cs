using System;

class MyClass
{
    private long _value;

    // Propriété pour accéder et modifier _value, garantissant que _value est toujours strictement positif
    public long Value
    {
        get { return _value; }
        set
        {
            if (value > 0)
                _value = value;
            else
                throw new ArgumentException("Value must be strictly positive.");
        }
    }

    // Constructeur
    public MyClass(long initialValue)
    {
        Value = initialValue; // Utilisation de la propriété pour garantir que la valeur est valide
    }
}
