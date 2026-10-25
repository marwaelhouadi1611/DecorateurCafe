namespace DecorateurCafe;

/// <summary>Composant concret : boisson de base.</summary>
public class Espresso : IBoisson
{
    public string Description() => "Espresso";

    public double Cout() => 2.50;
}
