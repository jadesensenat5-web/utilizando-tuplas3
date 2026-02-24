// 16. Tupla de 5 elementos y su longitud
var t8 = (10, 20, 30, 40, 50);
int longitud = t8.GetType().GetFields().Length;

Console.WriteLine("La longitud es: " + longitud);