using System;
using Figgle;
namespace Exerciciosoma
{
    class Program
    {
        static void Main(string[] args)
        {
                    Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //objetivo somar dois numeros

            Console.WriteLine("--Vou somar os dois digitos que você escolher!");
            Console.WriteLine("");
            //pedir pro usuario digitar dois numeros diferentes
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Digite...: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string X = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Digite...: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string Y = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            //monstrar os dois numeros = R
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"{X}");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write($" + ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write($"{Y} = ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"R");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("--------------------------");
            Decimal R = Convert.ToDecimal(X) + Convert.ToDecimal(Y);
            Double Rd = Convert.ToDouble(X) + Convert.ToDouble(Y);
            //e embaixo monstrar X + Y = R com as respostas
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Decimal | {X} + {Y} = {R}");

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            int Xint = Convert.ToInt32(X);
            int Yint = Convert.ToInt32(Y);
            int soma = Yint + Xint;
            Console.WriteLine($"Int | {Xint} + {Yint} = {soma}");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Double | {X} + {Y} = {Rd}");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("");
            Console.WriteLine($"RESULTADO DA OPERAÇÃO É: {soma}");

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("");
            Console.WriteLine("RESPOSTA:");
            Console.WriteLine("");
            string Resposta = Convert.ToString(Rd);
            Console.Write(FiggleFonts.Standard.Render(Resposta));



            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
            Console.ResetColor();
        }
    }
}
