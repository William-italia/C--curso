using System;

namespace ExercicioPesoIdeal
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Clear();

        Decimal alturaNR, pesoideal;
        String SexoUsuario;
        bool  alturaV;

        Console.WriteLine("- - - Peso Ideal - - -\n");

        Console.Write("Digite sua altura em Metros...: ");
        alturaV = decimal.TryParse(Console.ReadLine(), out alturaNR);

        if (!alturaV)
        {
            Console.WriteLine($"Digite uma altura valida");
            Environment.Exit(-1);
        }
        Console.Write("Sexo [M]asculino ou [F]eminino...: ");
        SexoUsuario = Console.ReadKey().KeyChar.ToString().ToUpper();

        if (SexoUsuario.Equals("M"))
        {
            pesoideal = alturaNR * 72.7m - 58m;
             Console.WriteLine($"\nSeu peso ideal é {pesoideal:N1}kg.");
        }

        else if (SexoUsuario.Equals("F"))
        {
           pesoideal = alturaNR * 62.1m - 44.7m;
             Console.WriteLine($"\nSeu peso ideal é {pesoideal:N1}kg.");
        }
        }

    }
}
