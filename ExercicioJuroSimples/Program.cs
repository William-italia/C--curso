using System;

namespace ExercicioJuroSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Strings
            string c, i, t;
            // Codigo inicial
            Console.WriteLine("- - - Juros Simples - - -");
            Console.WriteLine("");
            Console.WriteLine("");
            //pegar dados
            Console.Write("Capital [R$].......: ");
            c = Console.ReadLine();
            Console.Write("Taxa de juros [%]..: ");
            i = Console.ReadLine();
            Console.Write("Tempo (meses)......: ");
            t = Console.ReadLine();
            //codigo calculo
            Decimal C = Convert.ToDecimal(c);
            Decimal I = Convert.ToDecimal(i);
            Decimal T = Convert.ToDecimal(t);
            //codigo resultado
           // j = c . i . t // m = c + j
            Decimal juros = (C * I * T) / 100;
            Decimal Montante = C + juros;
            //resultado
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Juros......: R$ {juros:N}");
            Console.WriteLine($"Montante...: R$ {Montante:N}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
