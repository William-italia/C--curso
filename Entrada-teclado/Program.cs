using System;

namespace Entrada_teclado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Digite seu nome...");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string nomeUsuario = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Obrigado!, ");
            Console.Write(nomeUsuario);
            Console.ResetColor();
        }
    }
}
