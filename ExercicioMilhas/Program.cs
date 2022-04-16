using System;

namespace ExercicioMilhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("--- {CONVERSOR DE MILHAS PARA KILOMETROS} ---");
            Console.WriteLine("");
            Console.Write("Milhas....: ");
            String Milhas = Console.ReadLine();
            
            //pegar o numero digitado pelo usuario e multiplicar por 1.6
            decimal X = Convert.ToDecimal(1.6);
            decimal milhaDitg = Convert.ToDecimal(Milhas);
            Decimal MxK = milhaDitg * X; 
            
            //mostrar resultado
            Console.Clear();
            
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine($"Milhas.....: {milhaDitg} * 1.6 ");
            Console.WriteLine("");
            Console.WriteLine($"Resultado..: {MxK}Km");
            
            Console.ReadKey();
            Console.Clear();

            
            Console.WriteLine("--- {CONVERSOR DE KILOMETROS PARA MILHAS} ---");
            Console.WriteLine("");
            Console.Write("Kilometros..:");
            String kilometros = Console.ReadLine();

            Decimal Y = Convert.ToDecimal(1.6);
            Decimal kiloDigt = Convert.ToDecimal(kilometros);
            decimal KdM = kiloDigt / Y;

            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine($"Kilometros..: {kiloDigt} / 1.6 ");
            Console.WriteLine("");
            Console.WriteLine($"Resultado..: {KdM} Milhas");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("--ENTER PARA FINALIZAR--");
            Console.ReadKey();




        }
    }
}
