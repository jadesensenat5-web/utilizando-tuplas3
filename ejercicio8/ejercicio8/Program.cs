// 8. Calcular la longitud de una cadena

Console.Write("Escribe una palabra o frase: ");
string entrada = Console.ReadLine();

Console.WriteLine("La longitud es: " + ObtenerLargo(entrada));
static int ObtenerLargo(string s) => s.Length;