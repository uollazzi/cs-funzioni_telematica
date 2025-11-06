// valori di ritorno
using System.Reflection.Metadata;

void Saluta()
{
    Console.WriteLine($"Ciao, sono le {DateTime.Now}");
    Thread.Sleep(1000);
}

Saluta();

string RitornaUnSaluto()
{
    return $"Ciao, sono le {DateTime.Now}";
}

for (int i = 0; i < 5; i++)
{
    string saluto = RitornaUnSaluto();
    Console.WriteLine(saluto);

    // Console.WriteLine(RitornaUnSaluto()); // oppure
    // Thread.Sleep(1000);
}

// tupla
bool maggiorenne = true;
(int, string) tupla = (3, "ciao");
var tupla2 = (4, 9.5m, "ciao");

Console.WriteLine($"{tupla.Item1} e {tupla.Item2}");

(int eta, string nome, bool sposato) tupla3 = (14, "Mario", true);

(string nome, List<string> invitati) evento = ("Sagra della Salsiccia", ["Gigi", "Mario", "Anna"]);
foreach (var invitato in evento.invitati)
{
    Console.WriteLine(invitato);
}

int TiraUnDado()
{
    Random rnd = new Random();

    return rnd.Next(1, 7);
}

(int rosso, int blu) TiraDueDadi()
{
    return (TiraUnDado(), TiraUnDado());
}

var r = TiraDueDadi();
Console.WriteLine($"Rosso: {r.rosso}");
Console.WriteLine($"Blu: {r.blu}");
