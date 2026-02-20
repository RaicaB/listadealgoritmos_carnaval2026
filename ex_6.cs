using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        int vendaMedia = ReadInt("Digite a venda média mensal: ");
        double precoAtual = ReadDouble("Digite o preço atual do produto: ");

        double novoPreco = precoAtual;
        if (vendaMedia < 500 && precoAtual < 30)
        {
            novoPreco = precoAtual * 1.10; // aumento de 10%
        }
        else if (vendaMedia >= 500 && precoAtual >= 30)
        {
            novoPreco = precoAtual * 0.80; // redução de 20%
        }

        Console.WriteLine($"O novo preço do produto é: R$ {novoPreco:F2}");
    }

    static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out var value))
                return value;
            Console.WriteLine("Entrada inválida. Digite um número inteiro.");
        }
    }

    static double ReadDouble(string prompt)
    {
        var culture = CultureInfo.CurrentCulture; // ou CultureInfo.InvariantCulture
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), NumberStyles.Float, culture, out var value))
                return value;
            Console.WriteLine("Entrada inválida. Digite um número decimal válido.");
        }
    }
}