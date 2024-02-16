using System;

namespace exerciciosequencialimites
{
  class Program
  {
    static void Main(string[] args)
    {
      int num1, num2;

      Console.Write("Digite o primeiro numero: ");
      num1 = Convert.ToInt32(Console.ReadLine());

      Console.Write("Digite o segundo numero.: ");
      num2 = Convert.ToInt32(Console.ReadLine());

      if (num2 < num1)
      {
        Console.WriteLine("Digite um numero valido");
      }
      else
      {
        while (num1 <= num2)
        {
          int i = num1;
          num1++;
          Console.Write($"{i} ");
        }
      }

    }
  }
}
