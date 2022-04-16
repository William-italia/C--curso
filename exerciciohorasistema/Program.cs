using System;

namespace ExercicioHoraSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

        Console.WriteLine("");
        //Monstrar data e hora atual
        DateTime agora = DateTime.Now;
        Console.WriteLine("");
        Console.WriteLine($"Neste momento são exatamente {agora} ");

        }
    }
}
