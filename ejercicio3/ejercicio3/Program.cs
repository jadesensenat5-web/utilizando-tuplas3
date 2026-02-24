// // 3. numero par

Console.Write("Número: "); int n = int.Parse(Console.ReadLine());
Console.WriteLine(EsPar(n) ? "Es Par" : "Es Impar");

static bool EsPar(int num) => num % 2 == 0;
