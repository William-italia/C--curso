using System;

namespace exercicio_OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que exiba Olá usuário, eu me chamo Ermogenes! (utilize o seu nome).
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            //escreva Olá usuario. . . /n seja bem vindo ao meu programa, eu me chamo William!
            Console.Write("Olá usuario...");
            Console.WriteLine("");
            
            Console.WriteLine("Seja bem-vindo ao meu programa!.");
            Console.WriteLine("");
            Console.Write("Eu me chamo William,");



            //Falar para o usuario Digitar o nome
           
            Console.Write(" E você? ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;                                            //cor
            string nomeUsuario = Console.ReadLine();
            
            //string nome = nomeUsuario;
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            //Console.WriteLine("Pressione uma tecla para continuar. . .");
            //Console.ReadKey();
            //string mensagem = $" Prazer! {nomeUsuario}.";
            
            Console.Write("Bom te conhecer, ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;                                            //cor
            Console.Write(nomeUsuario);
            Console.Write("!");
            Console.WriteLine("");
            Console.WriteLine();

            //Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.DarkGray;                                         //cor
            Console.WriteLine("Obrigado por utilizar o programa!");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Clique enter para finalizar...");
            Console.ReadKey();
            

            Console.Clear();
            Console.ResetColor();
           

                                                    
                                                   

            
            
           

            

        }
    }
}
