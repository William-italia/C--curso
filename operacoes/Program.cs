using System;

namespace Operacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkRed;


            //Operações de aritméticos
            Console.WriteLine("---Operações de aritméticos");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            double X = 8;
            double Y = -6;
            double soma = X + Y;
            double diferença = X - Y;
            double Produto = X * Y;
            double Quociente = X / Y;
            Console.WriteLine($"{X} + {Y} = {soma}");
            Console.WriteLine($"{X} - {Y} = {diferença}");
            Console.WriteLine($"{X} * {Y} = {Produto}");
            Console.WriteLine($"{X} / {Y} = {Quociente}");

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            // Precedência
            Console.WriteLine("---Precedência");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            double n1 = 2, n2 = 3, n3 = 1;
            double r1 = n1 * n2 + n3;
            double r2 = n1 * (n2 + n3);
            double r3 = (n1 * n2) + n3;
            double r4 = ((n1 * n2) + n3) / n1;
            Console.WriteLine($"{n1} * {n2} + {n3} = {r1}");
            Console.WriteLine($"{n1} * ({n2} + {n3}) = {r2}");
            Console.WriteLine($"({n1} * {n2}) + {n3} = {r3}"); 
            Console.WriteLine($"(({n1} * {n2}) + {n3}) / {n1} = {r4}");

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkBlue;

            //Divisão inteira
            Console.WriteLine("---Divisão");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            int a = 7;
            int b = 2;
            int intInteiro = a / b;
            int intSobra = a % b;
            Console.WriteLine($"{a} / {b} = {intInteiro}");
            Console.WriteLine($"{a} % {b} = {intSobra}");

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkCyan;

            //Funções matematicas
            Console.WriteLine("---Funções matemáticas");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            double cubo2 = Math.Pow(2, 3);
            double raiz2 = Math.Sqrt(2);
            Console.WriteLine($"2e3 = {cubo2}");
            Console.WriteLine($"Raiz2 = {raiz2}");

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            //Funções trigonométricas
            Console.WriteLine("---Funções trigonométricas");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;

            double pi = Math.PI;
            double Seno30 = Math.Sin(30 * pi / 180);
            double cosseno60 = Math.Cos(60 * pi / 180);
            double tangente45 = Math.Tan(45 * pi / 180);
            Console.WriteLine($"P = {pi}");
            Console.WriteLine($"Seno de 30° = {Seno30}");
            Console.WriteLine($"Cosseno de 60° = {cosseno60}");
            Console.WriteLine($"Tangente de 45° = {tangente45}");

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            //Arredondamento
            Console.WriteLine("---Arredondamento");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Gray;
            Double piArredondado6 = Math.Round(pi, 6);
            Double piArredondado2 = Math.Round(pi, 2);
            Double piArredondado0 = Math.Round(pi, 0);
            Console.WriteLine($"π com 6 casas {piArredondado6:N10}");
            Console.WriteLine($"π com 2 casas {piArredondado2:N10}");
            Console.WriteLine($"π com 0 casas {piArredondado0:N10}");

        }
    }
}
