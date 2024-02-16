using System;

namespace ExercicioMaiorDeDois
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      int n1 = 0, n2 = 0, m = 0;
      string quantidadedigitada1, quantidadedigitada2;

      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("- - - Maior entre dois numeros - - -");
      Console.ForegroundColor = ConsoleColor.White;
      Console.WriteLine("Digite dois numeros abaixo... ");


      Console.Write("\nDigite um numero......: ");
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      quantidadedigitada1 = Console.ReadLine();
      bool NrValido1 = Int32.TryParse(quantidadedigitada1, out n1);

      Console.ForegroundColor = ConsoleColor.White;

      Console.Write("Digite mais um numero.: ");
      Console.ForegroundColor = ConsoleColor.DarkCyan;
      quantidadedigitada2 = Console.ReadLine();
      bool NrValido2 = Int32.TryParse(quantidadedigitada2, out n2);


      Console.ResetColor();
      Console.WriteLine(maiorigualinvalido(n1, n2, m, NrValido1, NrValido2));
    }
    static string maiorigualinvalido(int n1, int n2, int m, bool NrValido1, bool NrValido2)
    {
      m = n1;
    
      if (!NrValido1 || !NrValido2)
      {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("\nDigite somente números.");
        Console.ResetColor();
        Environment.Exit(-1);
      }
        
      if (n1 == n2 || n2 == n1)
      {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"\nOs numeros {n1} e {n2} são iguais, digite numeros diferentes.");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\nObrigado por utilizar o programa!");
        Console.ResetColor();
        Environment.Exit(-1);
      }

      if (n2 > n1)
      {
        m = n2;

        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"\nO maior numero é {m}");
          Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\nObrigado por utilizar o programa!");
        Console.ResetColor();
        Environment.Exit(-1);
      }
      if (n1 > n2)
      {
        m = n1;
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine($"\nO maior numero é {m}");
         Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("\nObrigado por utilizar o programa!");
        Console.ResetColor();
        Environment.Exit(-1);
      }


      return $"true";

    }
    }

}
