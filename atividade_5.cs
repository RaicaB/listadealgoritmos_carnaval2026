using System;
class Program
{
    static void Main()
    {
        Console.Write("Digite o número de horas trabalhadas no mês: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine());
        salarioTotal = horasTrabalhadas * valorHora;
    }
else
{
int horasExtras = horasTrabalhadas - horasNormaisMes;
    double valorHoraExtra = valorHora * 1.5;
    salarioTotal = (horasNormaisMes* valorHora) + (horasExtras* valorHoraExtra);
}
Console.WriteLine($"O salário total do funcionário é: R$ {salarioTotal:F2}");
}
}