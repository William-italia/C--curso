using System;

namespace ExercicioHeronTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
        Double a , b, c;
        Console.Clear();
        Console.WriteLine("- - - Exercicio heron triangulo - - -");

        Console.Write("(a): ");
        a = double.Parse(Console.ReadLine());
        Console.Write("(b): ");
        b = double.Parse(Console.ReadLine());
        Console.Write("(c): ");
        c = double.Parse(Console.ReadLine());
     
        if (!trianguloReal(a,b,c))
        {
            Console.WriteLine($"\nNão é um triângulo");
            Environment.Exit(-1);
        }
        else
        {
        string tipo = modelotriangulo(a, b, c);
        double area = areadotriangulo(a, b, c);

        Console.WriteLine($"\nO triângulo {a}, {b}, {c} é do tipo {tipo} e tem àrea de {area:N2}.");
        }

        }
        static bool trianguloReal(double a, double b, double c)
        {
            bool trianguloValido = (
                a < (b + c) 
                && a > Math.Abs(b - c)
                && b < (a + c)
                && b > Math.Abs(a - c)
                && c < (a + b)
                && c > Math.Abs(a - b)
            );
            return trianguloValido;
        }
        static string modelotriangulo(double a, double b, double c)
        {
            if (a == b && b == c)
            {
                return "Equilátero";
            }
            else if (a != b && a != c && b != c)
            {
                return "escaleno";
            }
            else
            {
                return "isósceles";
            }
        }
        static double areadotriangulo(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a)*(s - b)*(s - c));

        }
    }
}
