using System;

namespace ExercicioCalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {

        Console.Clear();

        DateTime now = DateTime.Now;
        DateTime idade = new DateTime(2004, 7, 20); //30/09/2004
        TimeSpan tempo = now - idade;
        string datas , dato;

       
        datas = idade.ToShortDateString();
        dato = Convert.ToString(tempo.Days);

        Console.WriteLine($"\nEu nasci em {datas} e já vivi {dato} Dias.\n\n");
        }
    }
}
