// 17. Tupla de ciudades a Lista

using System.Collections.Generic;
var ciudadesTupla = ("SD", "Santiago", "Moca", "La Vega", "Puerto Plata");
var listaCiudades = new List<string> {
    ciudadesTupla.Item1,
    ciudadesTupla.Item2,
    ciudadesTupla.Item3,
    ciudadesTupla.Item4,
    ciudadesTupla.Item5
};

Console.WriteLine("Primer ciudad de la lista: " + listaCiudades[0]);
