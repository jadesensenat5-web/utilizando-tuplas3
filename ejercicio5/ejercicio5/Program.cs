// 5. Programa que cuente el numero de vocales en una cadena

using System.Linq;
Console.Write("Escribe una frase: ");
string texto = Console.ReadLine();
Console.WriteLine("Total de vocales: " + ContarVocales(texto));
static int ContarVocales(string t) => t.Count(c => "aeiouAEIOU".Contains(c));