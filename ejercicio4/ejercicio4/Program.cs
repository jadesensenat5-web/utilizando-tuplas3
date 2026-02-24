// 4. Encontrar el mayor de dos numeros

using System;
Console.Write("Primer número: ");
double n1 = double.Parse(Console.ReadLine());
Console.Write("Segundo número: ");
double n2 = double.Parse(Console.ReadLine());
Console.WriteLine("El mayor es: " + EncontrarMayor(n1, n2));
static double EncontrarMayor(double a, double b) => a > b ? a : b;