using System;

namespace ExercicioGritador
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.DarkGray;


        Console.WriteLine("Olá usuário! ");
        Console.Write("Eu vou");
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.Write(" <GRITAR!!>");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.Write(" tudo que você digitar! ");
        
        Console.ReadKey();
        Console.Clear();

        Console.Write("Digite....: ");
        String mensagem = Console.ReadLine();
                
        Console.Clear();

        String Novamensagem = mensagem;
        
        Console.Write(Novamensagem.ToUpper());
        Console.Write("!!!"); 

        Console.ReadKey();
        Console.WriteLine();
        Console.Clear();

        }
    }
}
