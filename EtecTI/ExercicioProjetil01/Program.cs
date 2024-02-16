using System;

namespace ExercicioProjetil01
{
  class Program
  {
    static void Main(string[] args)
    {
      Double velocidade, angulo, anguloRadiano, hmax, xmax;
      const double Gravidade = 9.80665;

      Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.WriteLine("- - - Exercicio Projetil - - - \n");

        Console.ForegroundColor = ConsoleColor.White;
      Console.Write($"Entre com a velocidade, em m/s..: ");
      velocidade = Convert.ToDouble(Console.ReadLine());

      Console.Write($"Entre com o ângulo, em graus....: ");
      angulo = Convert.ToDouble(Console.ReadLine());

      anguloRadiano = (angulo * Math.PI) / 180;

      hmax = Math.Pow(velocidade * Math.Sin(anguloRadiano), 2) / (2 * Gravidade);
      xmax = (Math.Pow(velocidade, 2) * Math.Sin(anguloRadiano * 2)) / Gravidade;

      Console.Write($"\nAlcance.........:");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.Write($" {xmax:N2}");
        Console.ForegroundColor = ConsoleColor.White;
      Console.Write($" m\n");
      Console.Write($"Altura máxima...:");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
      Console.Write($" {hmax:N2}");
        Console.ForegroundColor = ConsoleColor.White;
      Console.Write($" m\n");
         
        Console.ResetColor();

    }
  }
}
