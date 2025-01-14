Carre c = new Carre { Longueur = 1.5 };
Forme cercle = new Cercle { Rayon = 2 };

// on ne peut pas instancier une classe abtraites car elle est incomplète
// Forme f = new Forme();


Console.WriteLine(c.CalculerAire()); //2.25
Console.WriteLine(cercle.CalculerAire()); //12.56


abstract class Forme
{
    public string Color { get; set; }

    // CalculerAire est une methode abstraites
    // pas encore défine
    // il appartiendra aux classes enfants d'implémenter cette méthode 
    public abstract double CalculerAire();
}

class Cercle : Forme
{
    public double Rayon { get; set; }

    public override double CalculerAire()
    {
        return Math.PI * Rayon * Rayon;
    }
}


class Carre : Forme
{
    public double Longueur { get; set; }

    public override double CalculerAire()
    {
        return Longueur * Longueur;
    }
}

class Rectangle : Forme
{
    public double Longueur { get; set; }
    public double Largeur { get; set; }
    public override double CalculerAire()
    {
        return Largeur * Longueur;
    }
}