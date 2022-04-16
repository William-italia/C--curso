Console.WriteLine("-- Vetores: Declaração, atribuição e aces");

int[] n = new int[3];
n[0] = 17;
n[1] = -5;
n[2] = 0;

int soma = n[0] + n[1] + n[2];
Console.WriteLine($"Soma = {soma}");

Console.WriteLine("--------------------------------------------------------------\n");
// -----------------------------------------------------------------------------------------------------------------------------

string[] linguagens;
linguagens = new string[4];

linguagens[0] = "Python";
linguagens[1] = "Java";
linguagens[2] = "C#";
linguagens[3] = "JavaScript";

string linguagemUtilizada = linguagens[2];

Console.WriteLine($"Linguagem utiliza: {linguagemUtilizada}");

Console.WriteLine("--------------------------------------------------------------\r");

string[] nomes = new string[] { "João", "Maria", "José", "Ana" };
string[] nomes2 = { "João", "Maria", "José", "Ana" };

//tamanho de um arranjo
Console.WriteLine($"Nosso vetor possui {nomes.Length} nomes.");

//percorrendo matrizes com laços usadno while
Console.WriteLine("-- Percorrendo arrays com while --");
int contador = 0;
while (contador < linguagens.Length)
{
  Console.WriteLine($"A {contador + 1}ª Linguagem é {linguagens[contador]}");
  contador++;
}

Console.WriteLine("\n-- Percorrendo arrays com for --");
for (int i = 0; i < linguagens.Length; i++)
{
  Console.WriteLine($"A {i + 1}ª linguagem é {linguagens[i]}");
}

Console.WriteLine("\n-- Percorrendo arrays com for, reverso --");
for (int i = linguagens.Length - 1; i >= 0; i--)
{
  Console.WriteLine($"A {i + 1}ª linguagem é {linguagens[i]}");
}

Console.WriteLine("\n ---- Laço foreach ---- ");
foreach (string linguagem in linguagens)
{
  Console.WriteLine(linguagem);
}

// Matrizes
Console.WriteLine(" -- matrizes: arrays multidimensionais");
int[,] a = new int[2, 4];
a[0, 3] = 15;

int[,] m = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

int itemdesejado = m[1, 2];
Console.WriteLine($"m[1, 2] = {itemdesejado}");

// iNFORMAÇOES SBRE UMA MATRIZ
Console.WriteLine("--- informações sobre uma matriz");
Console.WriteLine($"Tamanho: {m.Length}");
Console.WriteLine($"Numero de dimenções: {m.Rank}");
Console.WriteLine($"limite inferior da dimensão 0: {m.GetLowerBound(0)}"); //0
Console.WriteLine($"limite superior da dimensão 0: {m.GetUpperBound(0)}"); //1
Console.WriteLine($"limite inferior da dimensão 0: {m.GetLowerBound(1)}"); //2
Console.WriteLine($"limite superior da dimensão 0: {m.GetUpperBound(1)}"); //3

// percorrendo uma matriz com for
Console.WriteLine("-- percorrendo uma matriz  com for");

for (int i0 = m.GetLowerBound(0); i0 <= m.GetUpperBound(0); i0++)
{
  for (int i1 = m.GetLowerBound(1); i1 <= m.GetUpperBound(1); i1++)
  {
    Console.WriteLine($"m[{i0}, {i1}] = {m[i0, i1]}");
  }
}

Console.WriteLine("-- percorrendo uma matriz  com foreach");
foreach (int item in m)
{
  Console.Write($"item = {item} ");
}

//matrizes irregulares
Console.WriteLine("-- matrizes irregulares");
string[] filmes = {
  "Matrix",
  "Senhor dos Anéis",
  "Titanic"
};

string[][] generosDosFilmes = {
    new string[2] {"Ação", "Ficção Cientifica"},
    new string[1] {"Fantasia"},
    new string[] {"Romance", "Baseado em fatos reais"}
};

string filme = filmes[0];
string genero = generosDosFilmes[0][1];

Console.WriteLine($"\nO filme {filme} é do gênero {genero}");

//Percorrendo uma matriz irregular com for
Console.WriteLine("Percorrendo uma matriz irregular com for");
for (int i0 = 0; i0 < generosDosFilmes.Length; i0++)
{
  for (int i1 = 0; i1 < generosDosFilmes[i0].Length; i1++)
  {
    Console.WriteLine($"{filmes[i0]} --> {generosDosFilmes[i0][i1]}");
  }
}
//percorrendo uma matriz irregular com foreach
Console.WriteLine("\nPercorrendo uma matriz irregular com foreach");
foreach (string[] generosDoFilme in generosDosFilmes)
{
  foreach (string generoDoFilme in generosDoFilme)
  {
    Console.WriteLine(generoDoFilme);
  }
}

//alterando um vetor "in-place"
Console.WriteLine("-- alterando um vetor \"in-place\"");
Array.Sort(nomes);
Array.Reverse(nomes);


foreach (string nome in nomes)
{
  Console.WriteLine(nome);
}

//Aplicação: Entrada de intes em uma lista
Console.WriteLine("Aplicação: Entrada de intes em uma lista");
string[] estadosCivis = { "solteiro", "casado", "viúvo" };

Console.WriteLine("1.Solteiro\n2.Casado\n3.Viúvo");
Console.WriteLine("Digite seu estado civil: ");

int valorDigitado = Convert.ToInt32(Console.ReadLine());

string estadoCivilSelecionado = estadosCivis[valorDigitado - 1];
Console.WriteLine($"Selecionado: {estadoCivilSelecionado}");

//Aplicação: Guardar muitos valores
Console.WriteLine("Aplicação: Guardar muitos valores");
Console.WriteLine("Digite a quantidade de numeros: ");
int numeroDeItens = Convert.ToInt32(Console.ReadLine());

int[] rolagens = new int[numeroDeItens];

Random gerador = new Random();

for (int i = 0; i < numeroDeItens; i++)
{
  rolagens[i] = gerador.Next(1, 7);
}

foreach (int rolagem in rolagens)
{
  Console.Write($"{rolagem} ");
}
//Aplicação Sorteando valores em uma lista
Console.WriteLine("Aplicação Sorteando valores em uma lista");
string[] sobrenomes = {
  "Santos",
  "Gonçalves",
  "Carvalho",
  "Moura"
};

Console.WriteLine("Quantos nomes? ");
int quantidade = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= quantidade; i++)
{
  int Sorteionome = gerador.Next(nomes.Length);
  int SorteioSobrenome = gerador.Next(sobrenomes.Length);

  string nomeSorteado = $"{nomes[Sorteionome]} {sobrenomes[SorteioSobrenome]}";
  Console.WriteLine($"{i}º nome sorteado: {nomeSorteado}");
}