using System;

namespace git
{
    class Program
    {
        static void Main(string[] args)
        {
         // "isto é uma string" <-- entre aspas duplas
            // String Cidade = @"C:\Users\willi\Documents\DevCs\EntradaTeclado\git"; ex

            /* Console.Clear();

              String CidadeA = "Mongaguá \"SP\" ";
              String CidadeB = "Mongaguá\nItanhaem ";
             String CidadeC = "C:\\Users\\willi\\Documents\\DevCs\\EntradaTeclado\\git ";
              String CidadeE = @"C:\Users\willi\Documents\DevCs\EntradaTeclado\git ";

             Console.WriteLine(CidadeA);
             Console.WriteLine();
             Console.WriteLine(CidadeB);
             Console.WriteLine("");
             Console.WriteLine(CidadeC);
             Console.WriteLine();
             Console.WriteLine(CidadeE);
            */
         Console.Clear();
         string cidade = "Peruibe";
         string estado = "SP";

            //string cidadeComEstado = cidade + "/" + estado;
         string mensagem = $"A etec AB fica em {cidade}/{estado}.";

            // "mongagua + SP = MongaguáSP
            //Console.WriteLine(cidade + "/" + estado);

        string novamensagem = mensagem
            .Replace("e", "E")
            .Replace("E", "e");


         Console.WriteLine(novamensagem);
         //Console.WriteLine(cidadeComEstado);
         //Console.WriteLine(mensagem.ToUpper());
         //Console.WriteLine(mensagem.ToLower());  
        }
    }
}
