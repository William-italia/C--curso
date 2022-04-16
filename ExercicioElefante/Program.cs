using System;

namespace ExercicioElefante
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      Console.WriteLine("= = = Exercicio Elefante = = =");
      Console.Write("Quantos elefantes: ");
      int quantidade = Convert.ToInt32(Console.ReadLine());

      if (quantidade <= 2 || quantidade % 2 == 1)
      {
        Console.WriteLine("Digite um numero par, acima de dois");
      }
      else
      {
        int Elefante = 1;

        while (Elefante <= quantidade)
        {
          if (Elefante == 1)
          {
            Console.WriteLine($"\n{Elefante} elefante incomoda muita gente");
          }
          else
          {
            Console.WriteLine($"\n{Elefante} elefantes incomodam muita gente");
          }

          Elefante += 1;
          Console.Write($"{Elefante} elefantes ");

          int incomoda = 1;
          while (incomoda <= Elefante)
          {
            Console.Write("incomodam ");
            incomoda++;
          }
          Console.WriteLine("muito mais");
          Elefante++;

        }
      }
    }
  }
}
