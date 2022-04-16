using System;

namespace ExercicioParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            int numero;
            string numeroDig;
            bool Nrvalido;
            Console.WriteLine("- - - Par ou Impar - - -");

            Console.Write("\nDigite um numero: ");
            numeroDig = Console.ReadLine();
            Nrvalido = Int32.TryParse(numeroDig, out numero);

            if (!Nrvalido)
            {
                Console.WriteLine($"\nDigite um número valido.");
                Environment.Exit(-1);
            }
            if (numero % 2 == 0)
            {
                Console.WriteLine($"\nO numero: {numero} é par");
            }
            else
            {
                Console.WriteLine($"\nO numero: {numero} é impar");
            }
        }
    }
}
