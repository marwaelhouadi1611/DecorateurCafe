namespace DecorateurCafe;

/// <summary>Décorateur concret : ajoute de la crème fouettée.</summary>
public class CremeFouettee : DecorateurBoisson
{
    public CremeFouettee(IBoisson boisson) : base(boisson) { }

    public override string Description() => $"{boisson.Description()}, crème fouettée";

    public override double Cout() => boisson.Cout() + 0.90;
}
