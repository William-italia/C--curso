using System;

namespace exerciciotabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int fator, i, multiplicador, qntV;

            Console.WriteLine("= = = = = = = = = = = = = = = = = = = Tabuada = = = = = = = = = = = = = = = = = ");

            Console.Write("Digite o Valor do fator: ");
            fator = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite até quantas vezes você deseja multiplicar: ");
            qntV = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\n===============================================================================\n");

            for (i = 1; i <= qntV; i++)
            {
                multiplicador = fator * i;
                Console.WriteLine($"{fator} * {i} = {multiplicador}");
            }
            Console.WriteLine("\n===============================================================================");
            Console.ReadKey();
        }
    }
}
