using System;

namespace ExercicioGrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Clear();
        
        //strings
        string FD;
        //Codigo inicial
        Console.WriteLine("- - - Conversor de °F para °C . - - -"); 
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("°F = ");
        FD = Console.ReadLine();
        //codigo calculos   °C = (°F - 32) / 1.8
        Decimal F = Convert.ToDecimal(FD);
        Decimal Sb = 32;
        Decimal Div = Convert.ToDecimal(1.8);
        //codigo resultado
        Decimal Rf = (F - Sb) / Div;
        //resultado
        Console.WriteLine("");
        Console.WriteLine($"{FD}°F equivale a {Rf:N3}°C");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("- - - - - Enter - - - - -");
        Console.ReadKey();
        Console.Clear();
        
        }
    }
}
