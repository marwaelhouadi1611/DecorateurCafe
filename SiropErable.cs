namespace DecorateurCafe;

/// <summary>Décorateur concret : ajoute du sirop d'érable.</summary>
public class SiropErable : DecorateurBoisson
{
    public SiropErable(IBoisson boisson) : base(boisson) { }

    public override string Description() => $"{boisson.Description()}, sirop d'érable";

    public override double Cout() => boisson.Cout() + 0.75;
}
