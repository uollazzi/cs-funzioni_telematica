void LogTitolo(string titolo)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(titolo + ":");
    Console.ResetColor();
}

LogTitolo("Cartella root");
var root = Directory.GetCurrentDirectory();
Console.WriteLine(root);

// informazioni sulla directory
var rootInfo = new DirectoryInfo(root);
LogTitolo("rootInfo.Name");
Console.WriteLine(rootInfo.Name);
LogTitolo("rootInfo.Parent");
Console.WriteLine(rootInfo.Parent);

var dirs = Directory.GetDirectories(root); // ritorna path assoluti

LogTitolo("Lista directories di root");
Console.WriteLine(string.Join("\n", dirs));

dirs = Directory.GetDirectories("documenti"); // ritorna path relativi


LogTitolo("Lista directories di documenti");
Console.WriteLine(string.Join("\n", dirs));

// creazione directory
// documenti/foto
Directory.CreateDirectory(@"C:\Progetti\Tutorials\Planet\dotNET\cs-funzioni\documenti\foto");

Directory.CreateDirectory(Path.Join(root, "documenti/video"));

rootInfo.CreateSubdirectory("documenti/musica");

// files
var files = Directory.GetFiles(Path.Combine("documenti", "fatture", "2021"));

LogTitolo("Lista files");
Console.WriteLine(string.Join("\n", files));

files = Directory.GetFiles("documenti", "*.pdf", SearchOption.AllDirectories);

LogTitolo("Lista files pdf");
Console.WriteLine(string.Join("\n", files));

var filesInfo = rootInfo.GetFiles("*.pdf", SearchOption.AllDirectories);
LogTitolo("Lista files Info");

foreach (var file in filesInfo)
{
    Console.WriteLine($"{file.Name} {file.CreationTime}");
}

// lettura files di testo
var filePath = Path.Combine("documenti", "preventivi", "todo.txt");

LogTitolo("Lettura file di testo");
var testo = File.ReadAllText(filePath);
Console.WriteLine(testo);

var righe = File.ReadAllLines(filePath);

var numeroRiga = 1;
foreach (var riga in righe)
{
    Console.WriteLine($"{numeroRiga} - {riga}");
    numeroRiga++;
}

// scrittura file di testo
var fileDaScriverePath = Path.Combine("documenti", "preventivi", "note2.txt");
List<string> note = ["Ciao", "sono", "Groot"];
File.WriteAllLines(fileDaScriverePath, note);

File.WriteAllText(fileDaScriverePath, "Lorem ipsum dolor sit, amet consectetur adipisicing elit. Laudantium, reiciendis? Vero accusantium earum veniam odit reprehenderit totam id in impedit ea optio ullam, error amet nobis libero ratione repellat similique accusamus sapiente recusandae molestiae commodi voluptate iusto adipisci minus. In est quae iste exercitationem esse quam at nisi obcaecati expedita.");

File.AppendAllLines(fileDaScriverePath, note);

// copiare un file
string fileName = "f1.pdf";
string cartellaFatture = Path.Combine("documenti", "fatture");
string cartellaSorgente = Path.Combine(cartellaFatture, "2020");
string cartellaDestinazione = Path.Combine(cartellaFatture, "2021");

if (
    File.Exists(Path.Combine(cartellaSorgente, fileName)) &&
    !File.Exists(Path.Combine(cartellaDestinazione, "f3.pdf"))
)
{
    File.Copy(Path.Combine(cartellaSorgente, fileName), Path.Combine(cartellaDestinazione, "f3.pdf"));
    Console.WriteLine("Copia effettuata");
}
