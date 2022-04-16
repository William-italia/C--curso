using System;

namespace ExercicioAnaliseCredito
{
    class Program
    {
        static void Main(string[] args)
        {
        decimal renda, valorparcela, valordesejado, maiorparcela;
        int quantidadeParcelas;
        String PERMITIDOnegado;

        Console.WriteLine("- - - ANALISE DE CRÉDITO - - -");

        Console.Write("Valor desejado..........:");
        valordesejado = Convert.ToDecimal(Console.ReadLine());
        Console.Write("Quantidade de parcelas..:");
        quantidadeParcelas = Convert.ToInt32(Console.ReadLine());
        Console.Write("Renda...................:");
        renda = Convert.ToDecimal(Console.ReadLine());

        valorparcela = valordesejado / quantidadeParcelas;
        maiorparcela = renda / 100 * 30;

        
            Console.WriteLine($"Parcela: {valorparcela:C}");
            Console.WriteLine($"Maior parcela permitida: {maiorparcela:C}");

        if (valorparcela > maiorparcela)
        {
                PERMITIDOnegado = "Emprestimo negado";
        }
        else 
        {
                PERMITIDOnegado = "Emprestimo autorizado";
        }

        Console.WriteLine($"{PERMITIDOnegado}");
        }
    }
}
