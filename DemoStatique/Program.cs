

Chat c1 = new Chat { Couleur = "Noir", Nom = "Felix" };
Chat c2 = new Chat { Couleur = "Roux", Nom = "Steve" };

Chat.Race = "Siamois";

c1.SePresenter();
c2.SePresenter();

Chat.Race = "De goutières";

c1.SePresenter();
c2.SePresenter();

Console.WriteLine(Math.Pow(4, 5));

c1.Manger();
c2.Manger();

int[] t = [1, 2, 5];
List<int> l = [1, 2, 3];
int value = l.First(i => i > 2);
int value2 = t.First(i => i > 2);

Console.WriteLine(c1);

class Chat
{
    public string Nom { get; set; }
    public string Couleur { get; set; }

    public static string Race { get; set; }

    public void SePresenter()
    {
        Console.WriteLine($"Je m'appelle {Nom}, je suis {Couleur} et Ma race est {Race}");
    }

    public override string ToString()
    {
        return Nom;
    }
}

static class ChatExtensions
{
    public static void Manger(this Chat c)
    {
        Console.WriteLine($"{c.Nom} est en train de manger");
    }
}

