using System;

namespace ExercicioAsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine();
            Console.WriteLine("Opa! Bem-vindo ao meu programa!");

            Console.Write("Digite seu ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("<nome> ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("antes de continuarmos..:");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Nome:");            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string nomeUsuario = Console.ReadLine(); 
            Console.WriteLine();


            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("-Precione ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("<enter>, ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(nomeUsuario);
            Console.Write("!");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write(" Para ver as AsciiArt.");
            Console.ReadKey();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkRed;
           Console.WriteLine();
            Console.WriteLine(" ||  || ");
            Console.WriteLine(" \\\\()// ");
            Console.WriteLine("//(__)\\\\");
            Console.WriteLine("||    ||");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Aranha..");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("");
            Console.Write("-Pressione ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("<enter> ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("novamente, para ver outra AsciiArt! ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-----------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine();
            Console.WriteLine("   |");
            Console.WriteLine(" .'|'.");
            Console.WriteLine("/.'|\\ \\");
            Console.WriteLine("| /|'.|");
            Console.WriteLine(" \\ |\\/");
            Console.WriteLine("  \\|/");
            Console.WriteLine("   `");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine();
            Console.WriteLine("Folha..");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("-----------------------------------");
           
            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("");
            Console.Write("-Pressione ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("<enter> ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("para finalizar.. ");
            Console.WriteLine("");
            Console.ReadKey();
            
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("---");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Obrigado! por utilizar meu programa, ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(nomeUsuario);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("!");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("---");
            Console.WriteLine("");

            
            
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();




        }
    }
}
           
            
            
    



