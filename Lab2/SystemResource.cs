using System;
using System.Collections.Generic;
using System.Threading;

// Class to model a computer system resource
public class SystemResource
{
    public string Name { get; }

    public SystemResource(string name)
    {
        Name = name;
    }
}
