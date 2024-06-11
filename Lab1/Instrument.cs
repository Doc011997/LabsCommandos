using System;

// Classe de base abstraite Instrument
abstract class Instrument
{
    // Méthode abstraite à implémenter dans les classes dérivées
    public abstract void Play();

    // Constructeur de la classe de base
    public Instrument()
    {
        Console.WriteLine("Constructor of Instrument");
    }
}
