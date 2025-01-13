Fraction f1 = new()
{
    Nominateur = 1,
    Denominateur = 2,
};

Fraction f2 = new()
{
    Nominateur = 1,
    Denominateur = 2,
};

Fraction f3 = f1 + f2;

Console.WriteLine();

List<int> ints = [1, 2, 4, 5, 42];
Console.WriteLine(ints[1]);

class Fraction // nominateur denominateur   1.5/2  9/7 42/0
{
    // 2/3 + 4/5
    // (2 * 5) / (3 * 5) + (4 * 3) / (5 * 3)
    // 10/15 + 12/15 = 22/15

    private int nominateur;
    private int denominateur = 1;

    public int Nominateur
    {
        get
        {
            return nominateur;
        }
        set
        {
            nominateur = value;
        }
    }
    public int Denominateur 
    {
        get { return denominateur; }
        set 
        { 
            if(value == 0)
            {
                return;
            }
            denominateur = value; 
        }
    }

    public static Fraction operator+(Fraction f1, Fraction f2)
    {
        int denominateur = f1.Denominateur * f2.Denominateur;
        int nominateur = f1.nominateur * f2.Denominateur + f2.nominateur * f1.Denominateur;
        return new Fraction
        {
            Nominateur = nominateur,
            Denominateur = denominateur
        };
    }
}
