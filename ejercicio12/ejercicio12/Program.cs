// 12. Clase Libro
using System;
Libro miLibro = new Libro { titulo = "Cien años de soledad" };
miLibro.ImprimirTitulo();
class Libro
{
    public string titulo;
    public void ImprimirTitulo() => Console.WriteLine("Título del libro: " + titulo);
}
