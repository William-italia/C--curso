using System;

namespace ExercicioMaisTarde
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\n");
            DateTime agr = DateTime.Now;
            string horaAtual = agr.ToShortTimeString();

            TimeSpan seishorasemeia = new TimeSpan(6, 30, 0);
            DateTime maistarde = (agr + seishorasemeia);
            string daqui = maistarde.ToShortTimeString();


            Console.WriteLine($"Agora: {horaAtual}, mais tarde {daqui}\n");

        }
    }
}
