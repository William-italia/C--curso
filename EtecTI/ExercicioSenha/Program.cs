using System;

namespace ExercicioSenha
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Clear();
        
        const String Senha = "1234abcd"; 
        string senhaDigitada;

        Console.Write("Digite uma senha: ");
        senhaDigitada = Console.ReadLine();

        if (Senha == senhaDigitada)
        {
        Console.WriteLine("Acesso permitido");
        }
        else 
        {
        Console.WriteLine("Acesso Negado");
        }
        }
    }
}
