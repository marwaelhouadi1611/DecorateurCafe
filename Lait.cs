namespace DecorateurCafe;

/// <summary>Décorateur concret : ajoute du lait.</summary>
public class Lait : DecorateurBoisson
{
    public Lait(IBoisson boisson) : base(boisson) { }

    public override string Description() => $"{boisson.Description()}, lait";

    public override double Cout() => boisson.Cout() + 0.60;
}
