

// je libere les ressources utilisées
using (Chat c = new Chat())
{
    Console.WriteLine(c.Nom);
}// la methode dispose de l'instance c sera appelée à la fin de l'accolade

Console.WriteLine();

class Chat : Animal, IDisposable
{
    public string Nom { get; set; }
    public Chat(): this("Felix")
    {
        //Nom = "Felix";
    }
    public Chat(string nom):base(5)
    {
        Nom = nom;
    }

    // destructeur de la classe
    ~Chat()
    {
        // on ne sait jamais qd le destructeur sera appelé
        // pas très pratique
    }

    public void Dispose()
    {
        Console.WriteLine("Je libererai les ressources que j'utilise ici");
        // empêche l'appel de la methode finalize(destructeur) de l'instance
        GC.SuppressFinalize(this);
    }
}

class Animal
{
    public DateTime DateDeNaissance { get; set; }
    public Animal()
    {
        DateDeNaissance = DateTime.Now;
    }
    public Animal(int age)
    {
        DateDeNaissance = DateTime.Now.AddYears(-age);
    }
}
