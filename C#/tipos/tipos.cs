using System.Globalization;

float n5 = 4.5F;

string nome = "William";
object obj1 = "Joao";
object obj2 = 4.5F;

int n1 = int.MinValue;
int n1M = int.MaxValue;

double saldo = 10.35784;

System.Console.WriteLine($"{saldo:f2}");
System.Console.WriteLine(saldo.ToString("F2"));
System.Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
System.Console.WriteLine(n5);
System.Console.WriteLine(n1);
System.Console.WriteLine(n1M);
System.Console.WriteLine(nome);
System.Console.WriteLine(obj1);
System.Console.WriteLine(obj2);