using System;

namespace ExercicioFGTS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
        //strings
        string S, periodo;
        //obj
        Console.WriteLine("- - - - Calcule a parcela do FGTS (8%) - - - -");
        Console.WriteLine("");
        Console.WriteLine("");
        //Codigo inicial
        Console.Write("Salário.......: ");
        S = Console.ReadLine();
        Console.Write("Periodo (meses)..: ");
        periodo = Console.ReadLine();
        //Codigo calculo // Dit x 8 / 100
        Decimal Salário = Convert.ToDecimal(S);
        Decimal FGTS = Salário * 8 / 100;
        Decimal P = Convert.ToDecimal(periodo);
        Decimal Total = P * FGTS;
        //resultado
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine($"FGTS = {FGTS:C}");
        Console.WriteLine($"Total = {Total:C}");



        }
    }
}
