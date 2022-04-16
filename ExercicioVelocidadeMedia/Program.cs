using System;

namespace ExercicioVelocidadeMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
        //string    
        string M, T;
        //Codigo inicial
        Console.WriteLine("- - - Calcule a velocidade média - - -");
        Console.WriteLine("");
        //codigo nmr digitados // V = d / t (100 / 15)
        Console.Write("Distancia percorrida (m): ");
        M = Console.ReadLine();
        
        Console.Write("Tempo gasto (s): ");
        T = Console.ReadLine();

        Console.WriteLine("");
        //codigo calculos // V = d / t (100 / 15)
        Decimal d = Convert.ToDecimal(M);
        Decimal t = Convert.ToDecimal(T);
        //condigo resultado
        decimal Vm = d / t;
        //resultado
        Console.WriteLine($"Velocidade Média..: {Vm:N} m/s");
        //finalização
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("- - - - - ENTER FINALIZAR - - - - -");
        Console.ReadKey();
        Console.Clear();

        

        }
    }
}
