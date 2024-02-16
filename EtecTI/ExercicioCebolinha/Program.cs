using System;

namespace ExercicioCebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
           
        Console.Clear();

        Console.Write("Olá usuário! ");
        Console.ReadKey();
        Console.Clear();

        string FraseDigitada;
        Console.WriteLine("Escreva uma frase que eu vou transformala como se ela fosse dita pelo Cebolinha.");
        Console.WriteLine();
        Console.Write("Frase: ");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        FraseDigitada = Console.ReadLine();

        Console.Clear();

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("-----------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Frase Digitada: ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write(FraseDigitada);
        Console.WriteLine();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write("Frase Modificada: ");
        string novamensagem = FraseDigitada.Replace("R", "L").Replace("r", "l");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine(novamensagem);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("-----------------------------------------------------------");
        Console.Write("--------------------------enter----------------------------");
        Console.WriteLine();
        Console.WriteLine();
        
        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();

        





        }
    }
}
