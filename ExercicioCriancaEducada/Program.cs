using System;

namespace ExercicioCriancaEducada
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();
            // pedir para usuário(a) escrever uma frase;

            //string Frasedigitada;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Olá usuário...");
            Console.WriteLine("Me diga o que você pensa sobre o aluno que não faz a lição de casa. ↓ ↓ ↓");
            Console.WriteLine();
            Console.Write("Digite..: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            string Frasedigitada = Console.ReadLine();


            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("(Frase digitada: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(Frasedigitada);
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(")");


            Console.WriteLine();
            Console.WriteLine();


            string frasemodificada = Frasedigitada
                        .Replace("bobo", "#@$%*!&")
                        .Replace("boba", "#@$%*!&")
                        .Replace("chato", "#@$%*!&")
                        .Replace("chata", "#@$%*!&")
                        .Replace("feia", "#@$%*!&")
                        .Replace("feio", "#@$%*!&")
                        .Replace("boboca", "#@$%*!&")
                        .Replace("bocó", "#@$%*!&")
                        .Replace("tonto", "#@$%*!&")
                        .Replace("tonta", "#@$%*!&")
                        .Replace("palerma", "#@$%*!&")
                        .Replace("paspalho", "#@$%*!&")
                        .Replace("paspalha", "#@$%*!&")
                        .Replace("tantã", "#@$%*!&")
                        .Replace("panaca", "#@$%*!&")
                        .Replace("pentelho", "#@$%*!&")
                        .Replace("pentelha", "#@$%*!&")
                        .Replace("burro", "#@$%*!&")
                        .Replace("burra", "#@$%*!&")
                        .Replace("besta", "#@$%*!&")
                        .Replace("BOBO", "#@$%*!&")
                        .Replace("BOBA", "#@$%*!&")
                        .Replace("CHATO", "#@$%*!&")
                        .Replace("CHATA", "#@$%*!&")
                        .Replace("FEIA", "#@$%*!&")
                        .Replace("FEIO", "#@$%*!&")
                        .Replace("BOBOCA", "#@$%*!&")
                        .Replace("BOCÓ", "#@$%*!&")
                        .Replace("TONTO", "#@$%*!&")
                        .Replace("TONTA", "#@$%*!&")
                        .Replace("PALERMA", "#@$%*!&")
                        .Replace("PASPALHO", "#@$%*!&")
                        .Replace("PASPALHA", "#@$%*!&")
                        .Replace("TANTÃ", "#@$%*!&")
                        .Replace("PANACA", "#@$%*!&")
                        .Replace("PENTELHO", "#@$%*!&")
                        .Replace("PENTELHA", "#@$%*!&")
                        .Replace("BURRO", "#@$%*!&")
                        .Replace("BURRA", "#@$%*!&")
                        .Replace("BESTA", "#@$%*!&");

            Console.WriteLine();

            Console.Write("Eu sou um programa educado no seu lugar eu diria..: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(frasemodificada);
            Console.Write("!");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                    <enter>         ");

            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            //mudar cor do texto sendo digitado
            //mudar as palavrões para #@$%*!&


        }
    }
}
