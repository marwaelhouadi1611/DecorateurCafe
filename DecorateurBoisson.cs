namespace DecorateurCafe;

/// <summary>
/// Décorateur abstrait : implémente IBoisson ET contient une IBoisson.
/// Par défaut, il délègue tout à la boisson enveloppée. Les décorateurs
/// concrets redéfinissent les méthodes pour y ajouter leur comportement.
/// </summary>
public abstract class DecorateurBoisson : IBoisson
{
    protected readonly IBoisson boisson;

    protected DecorateurBoisson(IBoisson boisson)
    {
        this.boisson = boisson;
    }

    public virtual string Description() => boisson.Description();

    public virtual double Cout() => boisson.Cout();
}
