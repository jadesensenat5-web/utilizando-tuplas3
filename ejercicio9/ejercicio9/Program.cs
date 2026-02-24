// 9. Crear una clase persona.

using System;
Persona p = new Persona { nombre = "Jades" };
p.Saludar();
class Persona
{
    public string nombre;
    public void Saludar() => Console.WriteLine($"Hola, soy {nombre}");
}