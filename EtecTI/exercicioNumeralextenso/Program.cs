using System;
using Humanizer;

namespace exercicioNumeralextenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int numero;
            string numeroextenso;

            Console.Write($"Digite um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            numeroextenso =numero.ToWords();

            Console.WriteLine($"\n{numero} --->> {numeroextenso}\n\n");

        }
    }
}
