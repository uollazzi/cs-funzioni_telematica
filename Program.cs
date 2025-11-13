/*
Scrivere un programma che visualizzi la cartella "documenti"
in console come da esempio nel file screenshot.png

- Creare un programma dinamico,
  che cioè si adatti alla struttura delle cartelle nel momento in cui le modifichiamo
  senza che sia necessario riscrivere il programma
- Cercate di utilizzare delle funzioni per parti del programma che si ripetono.
- Le cartelle devono essere visualizzate con un colore diverso dai files.
- I files modificati da meno di 5 minuti devono assumere un colore diverso
- I files modificati da meno di 30 minuti (ma da più di 5) devono assumere un colore ancora diverso
*/
var oggi = DateTime.Now;

void Esamina(DirectoryInfo dir, int livello = 0)
{
    LogDIrectory(dir, livello);

    DirectoryInfo[] subDirs = [];
    FileInfo[] files = [];

    // cerco le sottodirectory
    subDirs = dir.GetDirectories();
    foreach (var dirInfo in subDirs)
    {
        Esamina(dirInfo, livello + 1);
    }

    files = dir.GetFiles();
    foreach (var fileInfo in files)
    {
        LogFile(fileInfo, livello + 1);
    }
}

void LogDIrectory(DirectoryInfo dirInfo, int livello)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"{GetSeparatore(livello)}{dirInfo.Name}");
    Console.ResetColor();
}

void LogFile(FileInfo fi, int livello)
{
    var t = oggi.Subtract(fi.LastWriteTime).TotalMinutes;
    string dataModifica = $"({Math.Floor(t)} minuti fa)";

    if (t < 5)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
    }
    else if (t < 30)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
    }

    Console.WriteLine($"{GetSeparatore(livello)}{fi.Name} {dataModifica}");
    Console.ResetColor();
}

string GetSeparatore(int livello)
{
    string retVal = "";
    for (int i = 0; i < livello; i++)
    {
        retVal += "|   ";
    }

    retVal += "|-- ";

    return retVal;
}


var root = new DirectoryInfo("document");
Esamina(root);