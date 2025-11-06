// lamba
// serve per creare funzioni anonime (usa e getta)
// action (non ritornano un valore)
// func (ritornano un valore)
List<int> numeri = [1, 2, 3, 4];

numeri.ForEach(x =>
{
    Console.WriteLine(x);
});

var quadrati = numeri.Select(x => x * x);

Console.WriteLine(string.Join(",", quadrati));

