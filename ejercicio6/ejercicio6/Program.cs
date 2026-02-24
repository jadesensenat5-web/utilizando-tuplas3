// 6. Convertir grados Celsius a Fahrenheit.

Console.Write("Grados Celsius: ");
double celsius = double.Parse(Console.ReadLine());
Console.WriteLine("Grados Fahrenheit: " + ToFahrenheit(celsius));
static double ToFahrenheit(double c) => (c * 9 / 5) + 32;
