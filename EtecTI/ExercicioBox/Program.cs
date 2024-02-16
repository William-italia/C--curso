using System;

namespace ExercicioBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("  Pressione ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("<enter>");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" para iniciar...");
            Console.ReadKey(); 
            
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine();

           

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("       +---------------+");
            Console.Write("       |");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("   <William>");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("   |");
            Console.WriteLine("");
            Console.WriteLine("       +---------------+");


           Console.WriteLine();
           Console.WriteLine();
                
           // Console.ReadKey(); 

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("  Precione ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("<enter>");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" para finalizar.");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("------------------------------------");
            Console.ReadKey();
            

            Console.ResetColor();
            Console.Clear();





        }
    }
}
