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
