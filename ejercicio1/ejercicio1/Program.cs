// 1. suma de dos numeros
Console.Write("Num 1: "); double a = double.Parse(Console.ReadLine());
Console.Write("Num 2: "); double b = double.Parse(Console.ReadLine());
Console.WriteLine("Suma: " + Sumar(a, b));

static double Sumar(double n1, double n2) => n1 + n2;