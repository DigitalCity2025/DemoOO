// initialisation
TypeDeFonction? maVariable = DireBye;

// ajouter une fonction
maVariable += DireBonjour;
maVariable?.Invoke();

// retirer une fonction
maVariable -= DireBye;
maVariable?.Invoke();

maVariable -= DireBonjour;
maVariable?.Invoke();

// List<int> l = [1, 2, 3, 4, 5, 6, 42, 47, 99];
List<string> list = ["papa", "maman", "Khun", "piu"];
List<string> result = Filtrer<string>(list, item => item.StartsWith("p"));

//List<int> result = Filtrer(l, nb => nb % 3 == 0);
// List<int> result = Filtrer(l, delegate (int nb) { return nb % 3 == 0; });
// List<int> result = l.Where((int nb) => nb % 3 == 0).ToList();
Console.WriteLine(string.Join(",", result));

//Filtre f1 = (nb) => nb % 3 == 0;
//Filtre f2 = EstPair;
//Filtre f3 = EstPlusQue5;


void DireBonjour()
{
    Console.WriteLine("Hello");
}

void DireBye()
{
    Console.WriteLine("Bye");
}

int Somme(int nb1, int nb2)
{
    return nb1 + nb2;
}

//List<int> FilterPairs(List<int> entree)
//{
//    List<int> sortie = new List<int>();
//    foreach (int i in entree) 
//    {
//        if(EstPair(i))
//        {
//            sortie.Add(i);
//        }
//    }
//    return sortie;
//}

//List<int> FilterPlusQue5(List<int> entree)
//{
//    List<int> sortie = new List<int>();
//    foreach (int i in entree)
//    {
//        if (EstPlusQue5(i))
//        {
//            sortie.Add(i);
//        }
//    }
//    return sortie;
//}

List<T> Filtrer<T>(List<T> entree, Filtre<T> f)
{
    List<T> sortie = new List<T>();
    foreach (T i in entree)
    {
        if (f.Invoke(i))
        {
            sortie.Add(i);
        }
    }
    return sortie;
}

bool EstPair(int nb)
{
    return nb % 2 == 0;
}

bool EstPlusQue5(int nb)
{
    return nb > 5;
}

delegate void TypeDeFonction();

delegate bool Filtre<T>(T nb); 
