using System;

namespace Exerc_Classes_Aluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno();

            Console.Write("Digite o nome do aluno: ");
            a1.Nome = Console.ReadLine();

            Console.Write("Digite as três notas do aluno: ");
            a1.N1 = double.Parse(Console.ReadLine());
            a1.N2 = double.Parse(Console.ReadLine());
            a1.N3 = double.Parse(Console.ReadLine());

            a1.NotaFinal();

            Console.WriteLine("NOTA FINAL: " + a1.NotaFinal());
            
            if(a1.VerificarSePassou() == true)
            {
                Console.WriteLine("APROVADO!");
            }
                Console.WriteLine("REPROVADO!");
                Console.WriteLine("FALTARAM " + a1.NotaRestante() + " PONTOS.");
        }
    }
}
