# Patron Décorateur — C#

Exemple de café personnalisable : espresso ou café filtre, avec lait,
sirop d'érable et crème fouettée.

## Prérequis

SDK .NET 8. Aucun package NuGet externe n'est nécessaire.

## Exécution

Depuis le dossier contenant `DecorateurCafe.csproj` :

```bash
dotnet run
```

On peut aussi ouvrir `DecorateurCafe.sln` dans Visual Studio
et exécuter avec **Ctrl + F5**.

## Sortie attendue

```text
Espresso : 2.50 $
Café filtre, lait, sirop d'érable : 3.35 $
Espresso, sirop d'érable, crème fouettée : 4.15 $
Café filtre, lait, sirop d'érable, sirop d'érable : 4.10 $
```
