using System;

namespace ExercicioRetangulo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("= = = Retangulo = = =");
      Console.Write("Largura: ");
      int Largura = Convert.ToInt32(Console.ReadLine());

      Console.Write("Altura: ");
      int Altura = Convert.ToInt32(Console.ReadLine());

      if (Largura < 1 || Largura > 20 || Altura < 1 || Altura > 20)
      {
        Console.WriteLine("Digite apenas medidas entre 1 e 20.");
      }
      else
      {

        int linha = 1;
        while (linha <= Altura)
        {
          Console.WriteLine();
          int coluna = 1;
          while (coluna <= Largura)
          {
            Console.Write("* ");
            coluna++;
          }
          linha++;
        }

      }
    }
  }
}
