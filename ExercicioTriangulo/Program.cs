using System;

namespace ExercicioTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            String Base, altura;
            //Calcule a area de um triangulo retangulo
            Console.WriteLine("---Calcule a Área de um Triângulo retângulo---");
        
            Console.WriteLine("");
            //pedir a base

            Console.Write("Digite a Base.......: ");
            Base = Console.ReadLine();
            Console.WriteLine("");

            //pedir a altura
            Console.Write("Digite a Altura.....: ");
            altura = Console.ReadLine();
            Console.WriteLine("");

            //multiplicar
            Decimal B = Convert.ToDecimal(Base);
            Decimal a = Convert.ToDecimal(altura);
            Decimal multiplicar = B * a;
            //dividir o resultado por 2

            decimal resultado = multiplicar / 2;

            //mostrar o resultado
            Console.WriteLine($"Área: {resultado}"); 
            Console.WriteLine("");
      
            Console.ReadKey();
            Console.Clear();







        }
    }
}
