using System;

namespace ExercicioMediaDecimal
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      int i;
      decimal maior = 0;
      decimal menor = 0;
      decimal nr = 0;
      Decimal soma = 0;
      Decimal media = 0;

      // perguntar quantos numeros o usuario quer digitar;
      Console.WriteLine("= = = Media Decimal = = =");

      Console.Write("Quantos numeros quer utilizar? ");
      int Quantidade = int.Parse(Console.ReadLine());

      // pegar a qnt e guardar os numeros 
      for (i = 1; i <= Quantidade; i++)
      {
        Console.Write("Número #0" + i + ": ");
        nr = Convert.ToDecimal(Console.ReadLine());

        // monstrar o maior, menor, o total da soma e a media
        if (i == 1)
        {
          maior = nr;
          menor = nr;
        }
        if (nr < menor)
        {
          menor = nr;
        }
        if (nr > maior)
        {
          maior = nr;
        }

        soma = soma + nr;
      }
      media = soma / Quantidade;
      Console.WriteLine($"\nTotal: {soma}");
      Console.WriteLine($"Media: {media:N2}");
      Console.WriteLine($"maior numero: {maior}");
      Console.WriteLine($"menor numero: {menor}");

      Console.ReadKey();
    }
  }
}

