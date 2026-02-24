// 7. Verificar si un número está en una lista

using System.Linq;
int[] numeros = { 10, 20, 30, 40, 50 }; // Tu lista de ejemplo
Console.Write("Busca un número en la lista: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(EstaEnLista(numeros, n) ? "Sí está en la lista" : "No se encontró");
static bool EstaEnLista(int[] lista, int num) => lista.Contains(num);