using System;
using Figgle;

namespace NomeAssciart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            string nmdigitado;
            Console.Write("\nDigite seu nome: ");
            nmdigitado = Console.ReadLine();
            
            Console.WriteLine(FiggleFonts.Standard.Render($"{nmdigitado}"));
        }
    }
}
