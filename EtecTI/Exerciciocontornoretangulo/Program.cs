using System;

namespace Exerciciocontornoretangulo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("= = = Retangulo = = =");
      Console.Write("Largura: ");
      int Largura = Convert.ToInt32(Console.ReadLine());

      Console.Write("Altura: ");
      int altura = Convert.ToInt32(Console.ReadLine());

      if (Largura < 1 || Largura > 20 || altura < 1 || altura > 20)
      {
        Console.WriteLine("Digite apenas medidas entre 1 e 20.");
      }
      else
      {
        int linhaAtual = 1;
        while (linhaAtual <= altura)
        {
          Console.WriteLine();

          int colunaAtual = 1;
          while (colunaAtual <= Largura)
          {

            if (linhaAtual == 1 || linhaAtual == altura)
            {
              Console.Write("*");
            }
            else
            {
              if (colunaAtual == 1 || colunaAtual == Largura)
              {
                Console.Write("*");
              }
              else
              {
                Console.Write(" ");
              }
            }

            colunaAtual += 1;
          }

          linhaAtual += 1;
        }
      }
    }
  }
}
