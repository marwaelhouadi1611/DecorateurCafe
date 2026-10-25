namespace DecorateurCafe;

/// <summary>
/// Composant : interface commune aux boissons de base et aux décorateurs.
/// </summary>
public interface IBoisson
{
    /// <summary>Retourne le texte décrivant la boisson et ses ajouts.</summary>
    string Description();

    /// <summary>Retourne le prix total de la boisson, ajouts compris.</summary>
    double Cout();
}
