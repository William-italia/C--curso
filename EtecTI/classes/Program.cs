using MeuBanco;

Cliente t1 = new Cliente("william", "italia");
// Conta c1; //null

Conta c1 = new Conta(t1, 100);
// {
//   Titular = "William",
//   // Saldo = 100
// };

Conta c2 = new Conta(new Cliente("Roberto", "Carlos"), 200);
// c2.Titular = "Roberto";
// // c2.Saldo = 200;




Console.WriteLine($"{c1.Titular.NomeCompleto()} tem {c1.Saldo:C2} e {c2.Titular.NomeCompleto()} tem {c2.Saldo:C2}.");