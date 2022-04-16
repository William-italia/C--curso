using System;

namespace ExercicioMemeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Gray;

        string frasedigitada, frasememetonervoso;

        Console.Write("Usuário(a) o que você acha sobre mim? ");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        frasedigitada = Console.ReadLine();
        
        Console.WriteLine();
        Console.WriteLine();
        Console.Clear();
        

        
        Console.WriteLine("------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("- E sabe o que eu penso de você?");
        frasememetonervoso = $"{frasedigitada.Remove(10)}...NÃO PERA.\nTo Nervoso";
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(frasememetonervoso);


        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                      enter");

        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();

        }
    }
}
