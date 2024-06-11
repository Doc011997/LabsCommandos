// Classe dérivée Brass
class Brass : Instrument
{
    // Méthode virtuelle à implémenter dans les classes dérivées
    public virtual void Blow()
    {
        Console.WriteLine("Blowing into Brass");
    }

    public override void Play()
    {
        throw new NotImplementedException();
    }

    // Constructeur de la classe Brass
    public Brass()
    {
        Console.WriteLine("Constructor of Brass");
    }
}