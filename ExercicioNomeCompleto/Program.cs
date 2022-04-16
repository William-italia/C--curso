using System;

namespace ExercicioNomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.Clear();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Digite seu primeiro nome: ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        String primeironome = Console.ReadLine();    
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Digite seu sobrenome....: ");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        String segundonome = Console.ReadLine();    

        Console.ResetColor();
        Console.Clear();
      
            
        Console.ForegroundColor = ConsoleColor.DarkRed;  
        Console.WriteLine("-----------------------------------------------");
        Console.ForegroundColor = ConsoleColor.Gray;
        String mensagem = $"Nome completo: {primeironome} {segundonome}."; 
        Console.WriteLine(mensagem);
        
        Console.WriteLine();

        String Novamensagem = $"Nome de catálogo: {segundonome}, {primeironome}."; 
        Console.WriteLine(Novamensagem);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("--------------------<ENTER>--------------------");

        Console.ReadKey();
        Console.ResetColor();
        Console.Clear();






        }
    }
}
