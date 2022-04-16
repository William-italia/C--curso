using System;

namespace ExercicioNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int number;

           Console.WriteLine("--- Digite um número e eu vou dizer se ele é negativo ---");

            Console.Write("\nDigite um número: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.Write("Você digitou um número negativo.\n");
                //Environment.Exit(-1); (ele encerra o programa sem mostrar msgm final)
            }


            Console.WriteLine("\nObrigado por me utilizar!");
        }
    }
}
