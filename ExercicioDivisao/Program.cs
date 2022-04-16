using System;

namespace ExercicioDivisao
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numerador, Denominador; 
            
            //Receba um numerador e um denominador. Exiba o resultado da divisão ou "Não é possível dividir por zero.", conforme o caso.
            Console.Clear();
            Console.WriteLine("--- Divisao ---\n");

            Console.Write("Digite o numerador....: ");
            bool numeradorV = Int32.TryParse(Console.ReadLine(), out Numerador);

            Console.Write("Digite o denominador...: ");
            bool DenominadorV = Int32.TryParse(Console.ReadLine(), out Denominador);


            
            if (!numeradorV || !DenominadorV ) 
            {
                Console.WriteLine("Numero invalido.");
                Environment.Exit(-1);
            }
            else if (Denominador == 0 || Denominador == -0) 
            {
                Console.WriteLine("Não é possível dividir por zero");
            }
            else
            {
            Console.WriteLine($"\n{Numerador} dividido por {Denominador} é {Numerador / Denominador}");
            }   

            Console.WriteLine("\nObrigado por utilizar o programa!!!");
        }
    }
}
