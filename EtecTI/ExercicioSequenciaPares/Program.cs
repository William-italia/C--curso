using System;

namespace ExercicioSequenciaPares
{
  class Program
  {
    static void Main(string[] args)
    {
      int i = 1;
      int n;

      Console.WriteLine("= = = Numeros pares entre 1 a X = = =");
      Console.Write("Digite um numero: ");
      n = Convert.ToInt32(Console.ReadLine());

      while (i <= n)
      {
        if ((i % 2) == 0)
        {
          Console.Write("{0} ", i);
        }
        i++;
      }
      
    }
  }
}