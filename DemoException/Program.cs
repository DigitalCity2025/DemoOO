try
{
    int nb = int.Parse(Console.ReadLine());
    Console.WriteLine(Diviser(42,nb));
    return;
}
catch (FormatException)
{
    Console.WriteLine("La valeur n'est pas un entier valide");
}
catch(ArgumentException)
{
    Console.WriteLine("La valeur ne peut pas être nulle");
}
catch(DivideByZeroException ex)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
    Console.ResetColor();
}
catch(Exception)
{
    Console.WriteLine("Erreur inconnue");
}
finally
{
    Console.WriteLine("Aurevoir !!");
}


double Diviser(double n1, double n2)
{
    if (n2 == 0)
    {
        // lancer un exception
        throw new DivideByZeroException();
    }
    return n1 / n2;
}

class DivideByZeroException: Exception
{
    public DivideByZeroException()
        : base("Division par 0 impossible")
    {
        
    }
}
