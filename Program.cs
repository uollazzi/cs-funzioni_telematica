using System.Globalization;

void LogTitolo(string titolo)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine(titolo + ":");
    Console.ResetColor();
}

var oggi = DateTime.Now;
LogTitolo("Data di oggi");
Console.WriteLine(oggi);

var ora = oggi.TimeOfDay;
LogTitolo("Orario");
Console.WriteLine(ora);

// creare una data
var scopertaAmerica = new DateTime(1492, 10, 12);
var durata = new TimeSpan(23, 16, 0); // durata, un lasso di tempo (usata anche per definire le ore)

scopertaAmerica = scopertaAmerica.Add(durata);
LogTitolo("Date e ora scoperta America");
Console.WriteLine(scopertaAmerica);

// DateTimeOffset = Date + Time + Offset
var oggiUTC = DateTimeOffset.UtcNow;
Console.WriteLine(oggiUTC);
Console.WriteLine(oggiUTC.LocalDateTime);

var data = DateTimeOffset.FromUnixTimeSeconds(1762941726);
Console.WriteLine(data.LocalDateTime);

Console.WriteLine(((DateTimeOffset)scopertaAmerica).ToUnixTimeSeconds());

// formattazione
LogTitolo("DateTime formattazione");
Console.WriteLine(oggi.ToString());
Console.WriteLine(oggi.ToShortDateString());
Console.WriteLine(oggi.ToLongDateString());
Console.WriteLine(oggi.ToShortTimeString());
Console.WriteLine(oggi.ToString("ddd, dd MMMM yyyy HH:mm"));
Console.WriteLine(oggi.ToString("ddd, dd MMMM yyyy HH:mm", new CultureInfo("en-EN")));

// parsing
DateTime d;
bool isSuccess = DateTime.TryParse("22/10/2025", out d);

LogTitolo("Parsing data");
Console.WriteLine(isSuccess);
Console.WriteLine(d);

isSuccess = DateTime.TryParse("10-22-2025", new CultureInfo("en-US"), out d);

LogTitolo("Parsing data");
Console.WriteLine(isSuccess);
Console.WriteLine(d);

isSuccess = DateTime.TryParseExact("10-22-2025 12:37", "MM-dd-yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);

LogTitolo("Parsing data");
Console.WriteLine(isSuccess);
Console.WriteLine(d.ToString());

var ieri = oggi.AddDays(-1);
LogTitolo("Ieri");
Console.WriteLine(ieri);

LogTitolo("Da quanto esiste l'America?");
var tempoPassato = oggi - scopertaAmerica;
Console.WriteLine((int)(tempoPassato.TotalDays / 365));
Console.WriteLine(Math.Floor(tempoPassato.TotalDays / 365));
