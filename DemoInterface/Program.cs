Secretaire monique = new Secretaire
{
    Nom = "monique",
    Telephone = new SamsungGalaxy()
};

monique.FaireUneCommande();

class VieuxNokia : ITelephone
{
    public List<string> Contacts { get; }

    public void ConsulterMails()
    {
        throw new NotImplementedException();
    }

    public void EnvoyerSMS()
    {
        throw new NotImplementedException();
    }

    public void Telephonner(string numero)
    {
        Console.WriteLine("Je telephone avec un Vieux Nokia");
    }
}
class SamsungGalaxy : ITelephone
{
    public List<string> Contacts { get; }

    public void ConsulterMails()
    {
        throw new NotImplementedException();
    }

    public void EnvoyerSMS()
    {
        throw new NotImplementedException();
    }

    public void Telephonner(string numero)
    {
        Console.WriteLine("J'appelle depuis un Samsung Galaxy");
    }

    public void Telephonner(int numero)
    {
        Console.WriteLine("J'appelle depuis un Samsung Galaxy");
    }
}


interface ITelephone
{
    const int value = 4;
    List<string> Contacts { get; }
    void Telephonner(string numero);
    void EnvoyerSMS();
    void ConsulterMails();
}


class Secretaire
{
    public string Nom { get; set; }

    public ITelephone Telephone { get; set; }

    public void FaireUneCommande() 
    {
        Telephone.Telephonner("0476/666666");
    }
}
