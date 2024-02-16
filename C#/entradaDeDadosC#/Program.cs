// Console.WriteLine("Digite o nome de quantas cores quiser separados por virgula");
// string entrada = Console.ReadLine();


// if (!string.IsNullOrEmpty(entrada)) 
// {
//     string[] coresArray = entrada.Split(',');

//     List<string> cores = new List<string>(coresArray.Length);

//     foreach (string cor in coresArray) {
//         cores.Add(cor.Trim());  
//     }

//     Console.Clear();

//     cores.ForEach(cor => Console.WriteLine(cor));
//     Console.WriteLine(coresArray.Length);

// } else {
//    Console.WriteLine("Nenhuma cor inserida"); 
// }


// System.Console.WriteLine("Digite o nome de tres cores diferentes:");
// string s = Console.ReadLine();

// string[] v = s.Split(',');
// string a = v[0].Trim();
// string b = v[1].Trim();
// string c = v[2].Trim(); 

// Console.Clear();
// System.Console.WriteLine(a);
// System.Console.WriteLine(b);
// System.Console.WriteLine(c);

using System.Globalization;

System.Console.WriteLine("Por favor Digite seu nome, sexo, idade, e altura separados por virgula, obrigado!");

string[] v = Console.ReadLine().Split(',');
string nome = v[0].Trim();
char sexo = char.Parse(v[1].Trim());
int idade = int.Parse(v[2].Trim());
double altura = double.Parse(v[3].Trim(), CultureInfo.InvariantCulture);

System.Console.WriteLine(nome);
System.Console.WriteLine(idade);
System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
System.Console.WriteLine(sexo);

