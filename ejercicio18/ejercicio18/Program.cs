// 18. Contar repetidos en una tupla

using System.Linq;
var t10 = (1, 2, 2, 3, 2, 4);
int[] arregloTemp = { t10.Item1, t10.Item2, t10.Item3, t10.Item4, t10.Item5, t10.Item6 };
int cantidad = arregloTemp.Count(n => n == 2);

Console.WriteLine("El número 2 aparece: " + cantidad + " veces");