// polymorphisme des classes
Animal c = new Chat();
c.Nom = "Felix";
c.DateNaissance = DateTime.Now;
c.DireBonjour();
c.Test();

//cast explicite
((Chat)c).Miauler();

Animal c1 = new Chien()
{
    Nom = "Pluto"
};
c1.DireBonjour();
// ne fonctionne pas
// ((Chat)c1).Miauler();


class Animal
{
    public string Nom { get; set; }
    public DateTime DateNaissance { get; set; }
    public virtual void DireBonjour()
    {
        Console.WriteLine($"Hello, je m'appelle {Nom}");
    }

    public void Test()
    {
        Console.WriteLine("test");
    }
}

class Chat : Animal
{
    public void Miauler()
    {
        Console.WriteLine("MIAOU");
    }

    public override void DireBonjour()
    {
        Console.WriteLine("MIAOU");
        base.DireBonjour();
    }

    // a eviter
    public new void Test()
    {
        Console.WriteLine("test chat");
    }
}

class Siamois : Chat
{
    public override void DireBonjour()
    {
        base.DireBonjour();
    }
}

class Chien : Animal
{
    public override void DireBonjour()
    {
        Console.WriteLine("Waf waf");
    }
    public void Aboyer()
    {
        Console.WriteLine("WAF");
    }
}
