using System;

namespace Exerc2_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("y: ");
            int y = int.Parse(Console.ReadLine());

            while (x != 0 && y != 0)
            {
                if(x > 0 && y > 0)
                {
                    Console.WriteLine("Primeiro");
                }
                else if(x < 0 && y > 0)
                {
                    Console.WriteLine("Segundo");
                }
                else if(x < 0 && y < 0)
                {
                    Console.WriteLine("Terceiro");
                }
                else
                {
                    Console.WriteLine("Quarto");
                }
                Console.Write("x: ");
                x = int.Parse(Console.ReadLine());

                Console.Write("y: ");
                y = int.Parse(Console.ReadLine());
            }

        }
    }
}
