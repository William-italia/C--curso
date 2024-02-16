using System;

namespace DecisaoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            //receber nota da prova 1
            //Receber nota da prova 2
            //Calcule a média das notas das duas provas (pegar as notas e dividir por 2)
            //se a média for < de 5 informe que o aluno foi reprovado

            //se não informe que o aluno foi aprovado
            
            //////CALCULE A MEDIA
        
            Console.Clear();
            Console.WriteLine("");

            Console.WriteLine("- - - Calcule a media - - -\n");
            Console.Write("Prova 1...: ");
            Decimal P1 = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Prova 2...: ");
            Decimal P2 = Convert.ToDecimal(Console.ReadLine());

            Decimal Media = P1 + P2 / 2;

            if (Media >= 5)
            {
                Console.WriteLine($"Aprovado, Nota: {Media}");
            }
            else
            {
                Console.WriteLine($"Reprovado, Nota: {Media}");
            }



            /////// DIGITE SUA IDADE
            Console.ReadKey();
            Console.Clear();

            int Idade;

            Console.WriteLine("");
            Console.WriteLine("- - - Digite sua idade - - -");

            Console.Write("Idade...:");
            Idade = Convert.ToInt32(Console.ReadLine());

            if (Idade < 18)
            {
                Console.WriteLine("Menor de idade");
            }
            else
            {
                Console.WriteLine("Maior de idade");
            }

            //////////// salario

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("- - - SALARIO - - -");

            int idade, numeroF;
            const decimal salario_base = 1000;
            const decimal beneficio_por_filho = 100;

            Decimal salario;

            Console.Write("Digite sua idade..:");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("quantos filhos..: ");
            numeroF = Convert.ToInt32(Console.ReadLine());

            if (idade < 18)
            {
                salario = salario_base;
            }
            else
            {
                decimal beneficio = numeroF * beneficio_por_filho;
                salario = salario_base + beneficio;
            }

            Console.WriteLine(salario);


              
            Console.ReadKey();
            Console.Clear();

            int IDADE;
            Console.WriteLine("- - - Digite sua idade - - -");
            Console.WriteLine("");
            Console.Write("Idade...: ");
            IDADE = Convert.ToInt32(Console.ReadLine());

            if (IDADE <=12)
            {
                Console.WriteLine("Criança");
            }
            else if (IDADE <=17)
            {
                Console.WriteLine("Adolescente");
            }
            else if (IDADE < 65)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("Idoso");
            }

            Console.ReadKey();
            Console.Clear();
            ////////SIMULADOR DE FINANCIAMENTO

            Decimal valorTotal = 1000.00m;
            int Parcelas;
            string qntDigitada;
            bool numeroValido; //true / false


            Console.WriteLine("- - - Simulador de Financiamento - - -\n");

            Console.Write("Financiamento de quantas vezes? ");

            qntDigitada = Console.ReadLine();

            numeroValido = Int32.TryParse(qntDigitada, out Parcelas);

            if (!numeroValido)
            {
                Console.WriteLine($" Quantidade de parcelas invalida, Digite um numero.");
            }
            else if (Parcelas <= 0 || Parcelas > 10)
            {
                Console.WriteLine($"Não é possivel parcelar em {Parcelas} vezes.");
            }
            else
            {
                Decimal valorParcela = valorTotal / Parcelas;
                Console.WriteLine($"Você pagará {Parcelas} parcela(s) fixa(s) de {valorParcela:C}.");
            }

            


            Console.WriteLine("\nObrigado por utilizar nosso programa!");

            //Em um jogo de adivinha, o usuário diz um número de 1 a 100. Se ele adivinhar,
            //ganha o jogo. Se ele errar, dê uma pista (é maior ou é menor). 
            //Caso esteja fora da faixa, exiba uma mensagem de orientação.
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("- - - Adivinhe o numero de 1 á 100- - - ");

            int NM = 54;

            int numeroD;


            Console.Write("Digite um numero...: ");
            numeroD = Convert.ToInt32(Console.ReadLine());

            if (numeroD < 1 || numeroD > 100)
            {
                Console.WriteLine("Numero invalido, digite um numero entre 1 e 100.");
            }
            else
            {
                if (numeroD == NM)
                {
                    Console.WriteLine("Você acertou!!");
                }
                else
                {
                    if (numeroD < NM)
                    {
                        Console.WriteLine($"O número que você digitou é menor. Digite um número maior que {numeroD}.");
                    }
                    else
                    {
                        Console.WriteLine($"O número que você digitou é maior. Digite um número menor que {numeroD}.");
                    }



                }

            }








        }
    }
}























