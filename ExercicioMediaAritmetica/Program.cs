using System;

namespace ExercicioMediaAritmetica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
        //strings
        String L1, L2, L3; 
        //Codigo inicial
        Console.WriteLine("- - - Media Aritmédica - - -");
        Console.WriteLine("");
        Console.WriteLine("Digite 3 números para calcular a media");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("");
        Console.Write("Numero 1: ");
        L1 = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Numero 2: ");
        L2 = Console.ReadLine();
        Console.WriteLine("");
        Console.Write("Numero 3: ");
        L3 = Console.ReadLine();
        Console.WriteLine("");
        //codigo calculos M = l1 + l2 + l3 = l4 / 3
        Decimal l1 = Convert.ToDecimal(L1);
        Decimal l2 = Convert.ToDecimal(L2);
        Decimal l3 = Convert.ToDecimal(L3);
        decimal L4 = (l1 + l2 + l3) / 3; 
        //Resultado
        Console.WriteLine("-----------------------------------------------------------------");
        Console.WriteLine("");
        

        Console.WriteLine($"Média....: {L4:N}");
        
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");

        Console.WriteLine("- - - - - enter - - - - -");
        Console.ReadKey();
        Console.Clear();

        }
    }
}
