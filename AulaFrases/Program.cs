using System;

namespace AulaFrases
{
    class Program
    {
        static void Main(string[] args)
        {
            //limpar tela
            Console.Clear();
            //mudar cor da letra para magenta
          
            Console.ForegroundColor = ConsoleColor.Magenta;

            //exibir frase
            Console.WriteLine("Você erra todos os arremessos que não tenta.");
            Console.WriteLine("--Michael jordan");
           

            //esperar q o usuario pressione uma tecla
            Console.WriteLine();
            Console.WriteLine("pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine();
            

            //mudar a cor para vermelho
             Console.ForegroundColor = ConsoleColor.DarkRed;

            //exibir segunda frase
            Console.WriteLine("Não existem metodos fáceis para resolver problemas dificies");
            Console.WriteLine("--René Descartes");
             Console.WriteLine();

            //aguardar q o usuario presione uma tecla
            Console.WriteLine("pressione uma tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine();

            // mudar a cor para amarelo 
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            //exibir a terceira frase
            Console.WriteLine("Todos caem, mas apenas os fracos continuam no chão.");
            Console.WriteLine("--Bob Marley");
            Console.WriteLine();
            //aguardar pressionar tecla
             Console.WriteLine("pressione uma tecla para finalizar...");
            Console.ReadKey();

            //voltar a cor padrao
            Console.ResetColor();
            
            //limpar tela
            Console.Clear();
         
        }
    }
}
