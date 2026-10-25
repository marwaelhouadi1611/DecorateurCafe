namespace DecorateurCafe;

/// <summary>Composant concret : boisson de base.</summary>
public class CafeFiltre : IBoisson
{
    public string Description() => "Café filtre";

    public double Cout() => 2.00;
}
