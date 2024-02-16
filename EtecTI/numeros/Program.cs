using System;

namespace Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("");

            //operaçoes de números inteiros
            Console.WriteLine("---Operações com inteiros ");
            Console.WriteLine("");
            int intX = 6;
            int intY = 8;
            int INTsoma = intX + intY;
            int INTsub = intX - intY;
            int INTmulti = intX * intY;
            int INTdiv = intX / intY;
            Console.WriteLine($"{intX} + {intY} = {INTsoma}");
            Console.WriteLine($"{intX} - {intY} = {INTsub}");
            Console.WriteLine($"{intX} * {intY} = {INTmulti}");
            Console.WriteLine($"{intX} / {intY} = {INTdiv}");

            Console.WriteLine("");

            //literais em ponto flutuante
            Console.WriteLine("---Literais em ponto flutuante");
            Console.WriteLine("");
            Double a = 1;
            Double b = +1;
            Double c = -1;
            Double d = 0.1;
            Double e = .1;
            Double f = 1.0;
            Double g = 1e0; // e = anotação cientifica n=elevado=potencia; 1 * 10e0
            Double h = 1d;  // D = tipo double
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");
            Console.WriteLine($"e = {e}");
            Console.WriteLine($"f = {f}");
            Console.WriteLine($"g = {g}");
            Console.WriteLine($"h = {h}");

            Console.WriteLine("");

            //Opéraçoes com pontoflutuante: double
            Console.WriteLine("--- Operações com ponto flutuante: double");
            Console.WriteLine("");
            Double doubleX = 6;
            Double doubleY = 8;
            Double DOUBLESoma = doubleX + doubleY;
            Double DOUBLESub = doubleX - doubleY;
            Double DOUBLEMulti = doubleX * doubleY;
            Double DOUBLEDiv = doubleX / doubleY;
            Console.WriteLine($"{doubleX} + {doubleY} = {DOUBLESoma}");
            Console.WriteLine($"{doubleX} - {doubleY} = {DOUBLESub}");
            Console.WriteLine($"{doubleX} * {doubleY} = {DOUBLEMulti}");
            Console.WriteLine($"{doubleX} / {doubleY} = {DOUBLEDiv}");

            Console.WriteLine("");

            //Operações com ponto flutuante: Decimal
            Console.WriteLine("---Operações com ponto flutuante: decimal");
            Console.WriteLine("");
            Decimal X = 6;
            Decimal Y = 8;
            decimal DecimalSoma = X + Y;
            decimal DecimalSub = X - Y;
            decimal DecimalMulti = X * Y;
            decimal DecimalDiv = X / Y;
            Console.WriteLine($"{X} + {Y} = {DecimalSoma}");
            Console.WriteLine($"{X} - {Y} = {DecimalSub}");
            Console.WriteLine($"{X} * {Y} = {DecimalMulti}");
            Console.WriteLine($"{X} / {Y} = {DecimalDiv}");

            Console.WriteLine("");

            //Formatação de números em ponto flutuante
            Console.WriteLine("---Formatação de números em ponto flutuante");
            Console.WriteLine("");
            Console.WriteLine($"Double = {DOUBLEDiv}, Decimal = {DecimalDiv} --SEM FORMATAÇÃO");
            Console.WriteLine($"Double = {DOUBLEDiv:N}, Decimal = {DecimalDiv:N} --FORMATO NUMERO ");
            Console.WriteLine($"Double = {DOUBLEDiv:C}, Decimal = {DecimalDiv:C} --FORMATO MOEDA ");
            Console.WriteLine($"Double = {DOUBLEDiv:C3}, Decimal = {DecimalDiv:C3} --FORMATO MOEDA 3CASAS ");
            Console.WriteLine($"Double = {DOUBLEDiv:N4}, Decimal = {DecimalDiv:N4} --NUMERO, 4 CASAS ");
            Console.WriteLine($"Double = {DOUBLEDiv:N30}, Decimal = {DecimalDiv:N30} --NUMERO, 30CASAS");

            Console.WriteLine("");

            // Conversões double/decimal
            Console.WriteLine("---Conversões double/decimal");
            Console.WriteLine("");
            double Doubleconversion = doubleX + Convert.ToDouble(X);
            decimal decimalconversion = X + Convert.ToDecimal(doubleX);
            Console.WriteLine($"Double = {Doubleconversion} | Decimal = {decimalconversion}");

            Console.WriteLine("");

            // Conversão via string
            Console.WriteLine("---Conversão via string");
            Console.WriteLine("");
            Decimal stringdecimal = Convert.ToDecimal("6,8");
            Double stringdouble = Convert.ToDouble("6,8");
            String decimalstring = DecimalDiv.ToString("N4");
            String stringDecimal = DOUBLEDiv.ToString("N4"); // tbm pode ser covert.tostring()
            Console.WriteLine($"Double = {stringdecimal} | Decimal {stringdouble}");
            Console.WriteLine($"Double = {stringDecimal} | Decimal {decimalstring}");

            Console.WriteLine("");

            //entrada via teclado
            Console.WriteLine("--- Entrada via teclado");
            Console.WriteLine("");
            Console.Write("Digite um numero....: ");
            string numDigitado = Console.ReadLine();
            Double doubledigitado = Convert.ToDouble(numDigitado);
            Decimal decimalDigitado = Convert.ToDecimal(numDigitado);
            Console.WriteLine($"Double = {doubledigitado} | Decimal = {decimalDigitado} | string {numDigitado}"); 
            

        }
    }
}
