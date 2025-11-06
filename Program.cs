int AggiungiUno(int numero)
{
    return numero + 1;
}

int Somma(int n1, int n2)
{
    return n1 + n2;
}

var risultato = Somma(3, 5);

risultato = Somma(n2: 6, n1: 9);

// C# passa i parametri come valore
// cioè di default, passa una copia della variabile
void quadratoByVal(int valParameter)
{
    valParameter *= valParameter;
}

int numero = 4;
quadratoByVal(numero);
Console.WriteLine(numero);

void quadratoByRef(ref int refParameter)
{
    refParameter *= refParameter;
}
quadratoByRef(ref numero);
Console.WriteLine(numero);

// output
string dieci = "10";
int rr;
bool ok = int.TryParse(dieci, out rr);
Console.WriteLine($"Riuscito: {ok}, risultato: {rr}");

// numero parametri variabile
int SommaMultipla(params int[] numeri)
{
    int r = 0;
    foreach (var n in numeri)
    {
        r += n;
    }

    return r;
}

Console.WriteLine(SommaMultipla(5, 7, 4, 8));
Console.WriteLine(SommaMultipla(5, 7, 4, 8, 7, 34, 56, 7));

// parametri di default (facoltativi)
void Saluta(string nome = "a tutti")
{
    Console.WriteLine($"Ciao {nome}");
}
Saluta("Pippo");
Saluta();

void SalutaNVolte(string nome, string saluto = "Ciao", int volte = 3)
{
    for (int i = 0; i < volte; i++)
    {
        Console.WriteLine($"{saluto} {nome}");
    }
}

SalutaNVolte("Bruno");
SalutaNVolte("Vario", "Salve");
SalutaNVolte("Anna", "Buongiorno", 8);

// salutare Luisa 5 volte senza sovrascrivere "Ciao"
SalutaNVolte("Luisa", volte: 5);

