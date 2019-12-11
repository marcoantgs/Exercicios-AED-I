using System;
using System.Globalization;

namespace Exerc1_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();

            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();

            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            string maior;

            if (p1.idade > p2.idade)
            {
                maior = p1.nome;
            }
            else
            {
                maior = p2.nome;
            }

            Console.WriteLine("Pessoa mais velha: " + maior);
        }
    }
}