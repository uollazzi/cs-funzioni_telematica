void LogTitolo(string titolo)
{
    Console.WriteLine("");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(titolo + ":");
    Console.ResetColor();
}

LogTitolo("Eccezioni comuni di sistema");

var n = 2;
var m = 0;

// Console.WriteLine("Divisione per zero");
// Console.WriteLine(n / m);

// Console.WriteLine("Indice oltre il range");
// string[] animali = ["cane", "gatto"];
// Console.WriteLine(animali[9]);

// costrutto try /catch
LogTitolo("Costrutto Try / Catch / Finally");
try
{
    var r = n / m;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
    Console.WriteLine("Eseguito anche se non c'ò stata eccezione");
}

LogTitolo("Costrutto Try / Catch * n / Finally");
StreamReader? file = null;

try
{
    file = new StreamReader("test.txt");
    var testo = file.ReadLine();

    var numero = int.Parse(testo);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("File non trovato");
    Console.WriteLine(ex.Message);
}
catch (FormatException ex)
{
    Console.WriteLine("Impossibile convertire la stringa in numero");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Eccezione non gestita, vedi sotto.");
    Console.WriteLine(ex.GetType());
    Console.WriteLine(ex.Message);
}
finally
{
    file?.Close();
    Console.WriteLine("Finally: File chiuso");
}

LogTitolo("Throw");
void CalcolaAnniPatente(int? eta)
{
    if (!eta.HasValue)
    {
        throw new NullReferenceException("Specificare gli anni");
    }

    if (eta < 18)
    {
        throw new Exception("Non ha la patente!");
    }

    Console.WriteLine($"Ha la patente da {eta - 18} anni.");
}

int? anni = 19;

try
{
    CalcolaAnniPatente(anni);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Eccezione null gestita");
    Console.WriteLine(ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Eccezione gestita");
    Console.WriteLine(ex.Message);
}

Console.WriteLine("FINITO");