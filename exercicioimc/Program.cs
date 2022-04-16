using System;

namespace ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
        //
        String AlS, PeS;
        //Codigo inicial
        Console.WriteLine("- - - Calcule sua massa corporal - - -");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        //IMC = peso / altura²
        Console.Write("Altura (m)..: ");
        AlS = Console.ReadLine();
        Console.Write("Peso (kg)...: ");
        PeS = Console.ReadLine();
        //Codigo calculo
        Double Al = Convert.ToDouble(AlS);
        Double Pe = Convert.ToDouble(PeS);
        Double Imc = Pe / Math.Pow(Al, 2);
        //resultado
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine($"IMC = {Imc:N} Kg/m²");
        //final
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("- - - - - enter para finalizar - - - - -");
        Console.ReadKey();
        Console.Clear();
        


        }
    }
}
