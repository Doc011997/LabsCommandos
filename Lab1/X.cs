using System;

class X
{
    // Attribut statique pour compter le nombre d'objets créés
    private static int count = 0;

    // Attribut d'instance pour stocker le numéro de l'objet
    private int objectNumber;

    // Constructeur
    public X()
    {
        count++;
        objectNumber = count;
    }

    // Remplacement de la méthode ToString()
    public override string ToString()
    {
        return $"Object from class X(Number {objectNumber})";
    }
}