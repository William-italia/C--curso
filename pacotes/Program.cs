using System;
using Figgle;
using Humanizer;

namespace Pacotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---FIGGLE: criando textos em ascii art.");
            Console.WriteLine("");
            Console.WriteLine("Digite seu texto, vou transformalo em uma ascii art");
            Console.Write("Digite...: ");
            string textodigitado = Console.ReadLine();
            Console.WriteLine(FiggleFonts.Standard.Render(textodigitado));

            //Humaziner: humanizando datas
            DateTime ataque = new DateTime(2001, 9, 11, 8, 46, 0);
            String ataque50 = ataque.AddYears(50).Humanize();
            String textoAtaque = ataque.Humanize();
            Console.WriteLine($"Ataque as torres gemeas: {textoAtaque}");
            Console.WriteLine($"50 anos do Ataque as torres gemeas: {ataque50}");
            Console.WriteLine("");
            Console.WriteLine("");

            //humanize numeros
            Console.WriteLine("---humanizer");
            int nmr = 7864;
            int independenciaBR = 1822;
            string BRtxt = independenciaBR.ToWords();
            string numerotxromano = independenciaBR.ToRoman();
            string numerotexto = nmr.ToWords();
            Console.WriteLine($"{nmr} ==> {numerotexto}");
            Console.WriteLine($"{independenciaBR} ==> {numerotxromano}");
            Console.WriteLine($"{BRtxt} ==> {independenciaBR}");



        }
    }
}
