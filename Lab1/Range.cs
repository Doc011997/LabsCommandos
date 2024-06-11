using System;

class Range
{
    private long _min;
    private long _max;

    // Propriété pour accéder et modifier _min, garantissant que _min est toujours inférieur ou égal à _max
    public long Min
    {
        get { return _min; }
        set
        {
            if (value <= _max)
                _min = value;
            else
                throw new ArgumentException("Min value must be less than or equal to Max value.");
        }
    }

    // Propriété pour accéder et modifier _max, garantissant que _max est toujours supérieur ou égal à _min
    public long Max
    {
        get { return _max; }
        set
        {
            if (value >= _min)
                _max = value;
            else
                throw new ArgumentException("Max value must be greater than or equal to Min value.");
        }
    }

    // Constructeur par défaut initialisant _min à 0 et _max à 100
    public Range()
    {
        _min = 0;
        _max = 100;
    }
}
