int[] valores;
valores = new int[] { 3, 5, 6, 5, 8, 9, 1, 5, 5 };
string[] paises = { "Nicaragua", "Cuba", "Venezuela" };

int total = 0;
foreach (int i in valores)
{
    total += i;
    Console.Write("{0} ", i);
}
Console.WriteLine("Total: " + total);

int[,] numeros = new int[2, 2] { { 5, 2 }, { 2, 3 } };
numeros[1, 1] = 10;

foreach(int i in numeros)
{
    Console.WriteLine("{0} ", i);
}

Console.WriteLine(valores.Length);

int[][] matriz = new int[3][];