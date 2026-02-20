using System;
class Program
{
    static void Main()
    {
        double S = 0;
        for (int i = 1; i <= 50; i++)
        {
            double numerador = (2 * i) - 1;
            double denominador = i;
            S += numerador / denominador;
        }
        Console.WriteLine($"O valor de S é: {S:F4}");
    }
}