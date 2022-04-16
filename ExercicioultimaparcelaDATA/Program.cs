using System;

namespace ExercicioultimaparcelaDATA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            string valordig, parcelas, horaatual, vencimentos; ;
            double digvalor, parcelasD, quantidadeparcelas, valor;
            bool NumeroValido, valorvalido;

            DateTime atual = new DateTime(2020, 5, 13);
            DateTime vencimento = atual.AddMonths(8).Date;
            horaatual = atual.ToShortDateString();
            vencimentos = vencimento.ToShortDateString();

            //pegar valores valor total / parcelas
            Console.WriteLine($"Data atual: {horaatual}");
            Console.Write("Valor total..................................:");
            valordig = Console.ReadLine();
            Console.Write("Quantidade de parcelas mansais (sem juros)...:");
            parcelas = Console.ReadLine();

            digvalor = Convert.ToDouble(valordig);
            parcelasD = Convert.ToDouble(parcelas);

            NumeroValido = double.TryParse(parcelas, out quantidadeparcelas);
            valorvalido = double.TryParse(valordig, out valor);



            if (!valorvalido)
            {
                Console.WriteLine("Valor invalido, digite um numero.");
                Environment.Exit(-1);
            }

            else if (quantidadeparcelas <= 0 || quantidadeparcelas > 10)
            {
                Console.WriteLine($"Não é possivel parcelar em {quantidadeparcelas} vezes.");
                Environment.Exit(-1);
            }
            else
            {
                Convert.ToDouble(parcelas);
                Convert.ToDouble(valordig);
                Double conta = digvalor / parcelasD;
                Console.WriteLine($"Sua ultima parcela será em {vencimentos} no valor de {conta:c}.");

            }





        }
    }
}
