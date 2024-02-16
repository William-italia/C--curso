using System;

namespace ExercicioGraus
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Clear();
        //strings
        string C;
        //Codigo inicial    
        Console.WriteLine("--- Conversor de °C para °F ---");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("°C = ");
        C = Console.ReadLine();
        Console.WriteLine("");
        //Codigo calculos  °F = °C * 1,8 + 32
        Double Cs = Convert.ToDouble(C);
        double M1_8 = 1.8;
        double S32 = 32;
        double S273_15 = 273.15;
        //Calculos
        Double F = Cs * M1_8 + S32;
        Double K = Cs + S273_15;
        Double R = (Cs + S273_15) * M1_8;
        //resultado
        Console.WriteLine($"{C}°C equivalem a {F}°F");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine($"{C}°C equivalem a {K} K");
        Console.WriteLine($"{C}°C equivalem a {R}°R");

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        
        Console.WriteLine("- - - - - Enter - - - - -");
        Console.ReadKey();
        Console.Clear();
        
        
        
        

        
        
        
        
        
        
        





        }
    }
}
