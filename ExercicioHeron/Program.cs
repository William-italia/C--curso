using System;

namespace ExercicioHeron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //strings
            String lado1, lado2, lado3;
            //Calcule a area de um triângulo
            Console.WriteLine("--- Calcule a Área de um triângulo ---");
            Console.WriteLine("");
            //pedir os lados do triangulo desejado
            Console.WriteLine("Digite quanto vale cada lado do triângulo");
            Console.WriteLine("");
            //lado1
            Console.Write("Lado1: ");
            lado1 = Console.ReadLine();
            //lado2
            Console.Write("Lado2: ");
            lado2 = Console.ReadLine();
            //lado3
            Console.Write("Lado3: ");
            lado3 = Console.ReadLine();
            //decimais
            Decimal a = Convert.ToDecimal(lado1);
            Decimal b = Convert.ToDecimal(lado2);
            Decimal c = Convert.ToDecimal(lado3);

            //calcular o semiperimetro
            decimal soma = a + b + c; 
            decimal P = soma / 2;
            //mostrar semiperimetro
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Semiperímetro..: {P}");
            //calcular a area A = VP.(P-A).(P-B).(P-C)
            decimal area = P * (P - a) * (P - b) * (P - c);
            Double raiz = Convert.ToDouble(area);
            //mostrar area
            Console.WriteLine($"Área...........: {Math.Sqrt(raiz)} cm2");

        }
    }
}
