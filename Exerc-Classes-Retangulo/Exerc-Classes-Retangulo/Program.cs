using System;

namespace Exerc_Classes_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo r = new Retangulo();

            Console.Write("Entre com a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine());
            r.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("ÁREA = " + r.Area());
            Console.WriteLine("PERÍMETRO = " + r.Perimetro());
            Console.WriteLine("DIAGONAL = " + r.Diagonal());
        }
    }
}
