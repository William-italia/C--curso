using System;

namespace ExercicioLeet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Olá usuário(a), ");
            Console.Write("vou traduzir seu texto para linguagem: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("leet speak");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(".");

            Console.WriteLine();

            Console.Write("Digite seu texto...: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string textodigitado = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.DarkGray;

            Console.Clear();
            Console.WriteLine();
        
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Texto a ser traduzido...: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(textodigitado);

            Console.WriteLine();
            Console.WriteLine();

            string textomodificado = textodigitado
                                    .Replace("A", "4")
                                    .Replace("a", "4")
                                    .Replace("E", "3")
                                    .Replace("e", "3")
                                    .Replace("I", "1")
                                    .Replace("i", "1")
                                    .Replace("L", "1")
                                    .Replace("l", "1")
                                    .Replace("O", "0")
                                    .Replace("o", "0")
                                    .Replace("T", "7")
                                    .Replace("t", "7")
                                    .Replace("S", "5")
                                    .Replace("s", "5");


            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Traduzido...: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(textomodificado);
            Console.ForegroundColor = ConsoleColor.DarkGray;
           
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------------------------------");

            Console.Write("-------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("ENTER");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("-------------------------------------");

            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();


        }
    }
}
            






