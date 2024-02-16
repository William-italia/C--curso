using System.Globalization;

double saldo = 10.35784;
string saldoFormat = saldo.ToString("F2", CultureInfo.InvariantCulture);


string nome = "William";
int idade = 20;

System.Console.WriteLine("{0} tem {1} anos e tem o saldo igual a {2} reais", nome, idade, saldoFormat);
System.Console.WriteLine($"{nome} tem {idade} anos e tem o saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais");



// System.Console.WriteLine(saldo.ToString(CultureInfo.InvariantCulture));
// System.Console.WriteLine(saldo.ToString("F2"));
// System.Console.WriteLine(saldo.ToString("F2",CultureInfo.InvariantCulture));


