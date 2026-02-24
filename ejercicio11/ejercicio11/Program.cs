// 11. Clase Coche

using System;
Coche miCoche = new Coche { color = "Azul" };
string elColor = miCoche.ObtenerColor();
Console.WriteLine("El color del coche es: " + elColor);
class Coche
{
    public string color;
    public string ObtenerColor() => color;
}