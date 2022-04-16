using System;

namespace ExercicioIdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Console.WriteLine("");
        Console.WriteLine("");
        DateTime ani = new DateTime(2004, 7, 20);
        String longa = ani.ToLongDateString();
        Console.WriteLine($"Eu nasci em: {longa}");

        DateTime ani18 = new DateTime(2022, 7, 20);
        String longa2 = ani18.ToLongDateString();
        Console.WriteLine($"Aniversario de 18 anos em: {longa2}.");
        Console.WriteLine("");
        

        }
    }
}
