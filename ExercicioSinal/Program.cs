using System;

namespace ExercicioSinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int numero;
            //Leia um número inteiro e exiba "Negativo", "Zero" ou "Positivo", conforme o caso.
            Console.WriteLine("--- Vou dizer se o numero digitado é zero ou negativo/positivo ---");

            Console.Write("\nDigite um número: ");
            bool numerovalido = Int32.TryParse(Console.ReadLine(), out numero);
            
            if (!numerovalido)
            {
                Console.WriteLine("Numero invalido.");
            }
            else if (numero == 0)
            {
                Console.WriteLine("Zero");
            }

            if (numero > 0)
            {
                Console.WriteLine("Positivo");
            }

            if (numero < 0)
            {
                Console.WriteLine("Negativo");
            }
            
        

        }
    }
}
