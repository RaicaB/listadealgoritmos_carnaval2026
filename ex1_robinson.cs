using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite x1: ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("Digite y1: ");
        double y1 = double.Parse(Console.ReadLine());
        Console.Write("Digite x2: ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("Digite y2: ");
        double y2 = double.Parse(Console.ReadLine());
        double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"A distância entre os pontos é: {distancia}");
    }
}