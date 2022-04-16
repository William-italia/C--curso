using System;

namespace ExercicioMaior2Numeros
{
  class Program
  {
    static void Main(string[] args)
    {
      double Num1, Num2, maior;

      Console.WriteLine("---Digite dois numeros abaixo.");

      Console.Write("Digite um numero.....: ");
      Num1 = double.Parse(Console.ReadLine());
      Console.Write("Digite mais um numero: ");
      Num2 = double.Parse(Console.ReadLine());
      
      if (Num1 > Num2)
      {
        maior = Num1;
      }
      else
      {
        maior = Num2;
      }

      Console.WriteLine($"O maior numero é {maior} .");
    }


  }
}
