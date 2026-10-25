using System.Globalization;
using System.Text;
using DecorateurCafe;

Console.OutputEncoding = Encoding.UTF8;

// Le client ne connaît que IBoisson : il ignore les décorateurs.
static void Afficher(IBoisson boisson)
{
    string prix = boisson.Cout().ToString("F2", CultureInfo.InvariantCulture);
    Console.WriteLine($"{boisson.Description()} : {prix} $");
}

// Boisson simple, sans décorateur
Afficher(new Espresso());

// Café filtre + lait + sirop d'érable (décorateurs empilés à l'exécution)
Afficher(new SiropErable(new Lait(new CafeFiltre())));

// Espresso + sirop d'érable + crème fouettée
Afficher(new CremeFouettee(new SiropErable(new Espresso())));

// Double ration de sirop : un même décorateur peut être appliqué 2 fois
Afficher(new SiropErable(new SiropErable(new Lait(new CafeFiltre()))));
