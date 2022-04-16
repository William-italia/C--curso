using System;

namespace ExercicioOlaUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Clear();

        Console.Write("Olá usuário....Digite seu nome: ");
        Console.ForegroundColor = ConsoleColor.DarkRed; 
        string nome = Console.ReadLine( );
        Console.ForegroundColor = ConsoleColor.Gray; 
        
        //Console.ReadKey();
        Console.Clear();
       // Console.WriteLine("");

        Console.Write("Olá, ");
        Console.ForegroundColor = ConsoleColor.DarkRed; 

        Console.Write(nome);
        Console.ForegroundColor = ConsoleColor.Gray; 
        Console.Write(" Prazer em conhece-lo!");

        Console.Write(" ");
        Console.ReadKey();
         /*
        Console.WriteLine("---------------------------------------------------");
        Console.Write("         Aperte ");
        Console.ForegroundColor = ConsoleColor.DarkRed; 
        Console.Write("<Enter> ");
        Console.ForegroundColor = ConsoleColor.Gray; 
        Console.WriteLine("Para finalizar....");
        Console.WriteLine("---------------------------------------------------");
        Console.ReadKey();
        */

        Console.ResetColor();
        Console.Clear();
            
        






        }
    }   
}
