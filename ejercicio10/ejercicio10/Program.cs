// 10.Clase Perro

using System;

Perro miPerro = new Perro { raza = "Golden Retriever" };
miPerro.ImprimirRaza();
class Perro
{
    public string raza;
    public void ImprimirRaza() => Console.WriteLine($"La raza es: {raza}");
}