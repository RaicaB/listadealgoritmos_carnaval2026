using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite o valor de A: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de B: ");
        int B = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de C: ");
        int C = int.Parse(Console.ReadLine());
        int R = (A + B) * (A + B);
        int S = (B + C) * (B + C);
        double D = (R + S) / 2.0;
        Console.WriteLine($"O valor de D é: {D}");
    }
}