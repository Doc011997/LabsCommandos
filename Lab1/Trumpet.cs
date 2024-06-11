// Classe dérivée Trumpet
class Trumpet : Brass
{
    // Implémentation de la méthode Play
    public override void Play()
    {
        Console.WriteLine("Playing Trumpet");
    }

    // Constructeur de la classe Trumpet
    public Trumpet()
    {
        Console.WriteLine("Constructor of Trumpet");
    }
}