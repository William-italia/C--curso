class Program 
{
    static void Main() 
    {

        // double a;
        // // float b;
        // int b;

        // a = 5.6;
        // b = (int)a;
        // System.Console.WriteLine(b);

        // int a = 5;
        // int b = 2;

        // double resultado = (double) a / b;

        // System.Console.WriteLine(resultado);

        double a = 1.0, b = -3.0, c = -4.0;

        double delta = Math.Pow(b, 2) - 4 * a * c;   

        if (delta < 0) {
            System.Console.WriteLine("A equação não possui raízes reais");
        } else {
            double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

            System.Console.WriteLine($"Raiz 1: {raiz1}");
            System.Console.WriteLine($"Raiz 2: {raiz2}");
        }

    }

}