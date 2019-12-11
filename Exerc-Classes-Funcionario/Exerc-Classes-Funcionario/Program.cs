using System;

namespace Exerc_Classes_Funcionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F1 = new Funcionario();

            Console.Write("Nome: ");
            F1.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            F1.SalarioBruto = double.Parse(Console.ReadLine());

            Console.Write("Imposto: ");
            F1.Imposto = double.Parse(Console.ReadLine());

            Console.WriteLine("Funcionário: " + F1);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double p = double.Parse(Console.ReadLine());

            F1.AumentarSalario(p);

            Console.WriteLine("Dados atualizados: " + F1);
        }
    }
}
