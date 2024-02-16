using System;
using System.Linq;
using Exercicio_agenda.db;

bool sair = false;
while (!sair)
{
  string opcao = SelecionaOpcaoEmMenu();

  Console.WriteLine($"Opção selecionada: {opcao}\n");

  switch (opcao)
  {
    case "L":
      ListarTodosContatos();
      break;

    case "T":
      Top5Contatos();
      break;

    case "C":
      ConsultarContatosPorCodigo();
      break;

    case "N":
      ConsultarContatosPorNome();
      break;

    case "I":
      IncluirContato();
      break;

    case "S":
      Console.WriteLine("- Sair");
      sair = true;
      break;

    default:
      Console.WriteLine($"Opção não reconhecida.");
      break;
  }

  Console.Write("\nPressione uma tecla para continuar...");
  Console.ReadKey();
}

static string SelecionaOpcaoEmMenu()
{
  Console.Clear();
  Console.WriteLine("-- Agenda --\n");
  Console.WriteLine("[L]istar todos os contatos");
  Console.WriteLine("[T]op 5 contatos");
  Console.WriteLine("Consultar contatos por [C]ódigo");
  Console.WriteLine("Consultar contatos por [N]ome");
  Console.WriteLine("[I]ncluir contato");
  Console.WriteLine("[S]air");
  Console.Write("\nDigite a sua opção: ");

  string entrada = Console.ReadLine().ToUpper().Trim();
  return entrada.Length < 2 ? entrada : entrada.Substring(0, 1);
}

static void ListarTodosContatos()
{
  Console.WriteLine("- Listar todos os contatos:");

  using (var agenda = new agendaContext())
  {
    int qtdDeContatos = agenda.Contatos.Count();
    if (qtdDeContatos == 0)
    {
      Console.WriteLine($"Nenhum contato cadastrado.");
      return;
    }
    Console.WriteLine($"{qtdDeContatos} contato(s) encontrado(s)");

    foreach (var contato in agenda.Contatos)
    {
      Console.WriteLine($"id {contato.Id}: Nome: {contato.Nome}, Tel: {contato.Fone}, {contato.Estrelas} estrelas");
    }

  }
}

static void Top5Contatos()
{
  Console.WriteLine("- Top 5 contatos:");

  using (var agenda = new agendaContext())
  {
    int qtdDeContatos = agenda.Contatos.Count();
    if (qtdDeContatos == 0)
    {
      Console.WriteLine($"Nenhum contato cadastrado.");
      return;
    }
    Console.WriteLine($"{qtdDeContatos} contato(s) encontrado(s)");

    var top5 = agenda.Contatos.OrderByDescending(c => c.Estrelas).Take(5);

    int posicao = 0;
    foreach (var contato in top5)
    {
      posicao++;
      Console.WriteLine($"#{posicao} = id {contato.Id}: Nome: {contato.Nome}, Tel: {contato.Fone}, {contato.Estrelas} estrelas");
    }

  }
}


static void ConsultarContatosPorCodigo()
{
  Console.WriteLine("- Consultar contatos por Código:");

  Console.Write("Digite o id: ");
  string codigoDigitado = Console.ReadLine();

  int busca;
  bool ehnumero = int.TryParse(codigoDigitado, out busca);

  if (!ehnumero)
  {
    Console.WriteLine("id inválido, digigte um numero.");
    return;
  }

  using (var agenda = new agendaContext())
  {
    var contato = agenda.Contatos.SingleOrDefault(c => c.Id == busca);

    if (contato is null)
    {
      Console.WriteLine($"Nenhum contato com o id {busca} encontrado.");
    }
    else
    {
      Console.WriteLine($"id {contato.Id}: Nome: {contato.Nome}, Tel: {contato.Fone}, {contato.Estrelas} estrelas");
    }

  }
}

static void ConsultarContatosPorNome()
{
  Console.WriteLine("- Consultar contatos por Nome:");

  Console.Write("Digite o nome do contato: ");
  string nomeBusca = Console.ReadLine().Trim();

  using (var agenda = new agendaContext())
  {
    var contatosFiltrados = agenda.Contatos.Where(c => c.Nome.Contains(nomeBusca));
    int qtdEncontradas = contatosFiltrados.Count();
    if (qtdEncontradas == 0)
    {
      Console.WriteLine($"Nenhum contato encontrado contendo \"{nomeBusca}\"");
      return;
    }
    Console.WriteLine($"{qtdEncontradas} contato(s) encontrado(s)");

    foreach (var contato in contatosFiltrados)
    {
      Console.WriteLine($"id {contato.Id}: Nome: {contato.Nome}, Tel: {contato.Fone}, {contato.Estrelas} estrelas");
    }

  }

}

static void IncluirContato()
{
  Console.WriteLine("- Incluir contato:");

  Console.Write("Nome......: ");
  string nomeDesejado = Console.ReadLine().Trim();

  if (nomeDesejado == string.Empty)
  {
    Console.WriteLine("Nome Requerido.");
    return;
  }

  using (var agenda = new agendaContext())
  {
    var existeNome = agenda.Contatos.SingleOrDefault(c => c.Nome == nomeDesejado);

    if (existeNome is not null)
    {
      Console.WriteLine($"Contato Existente com o nome indicado: {existeNome.Id}");
      return;
    }
  }


  Console.Write("Fone......: ");
  string fone = Console.ReadLine().Trim();

  Console.Write("Estrelas..: ");
  string estrelasDigitado = Console.ReadLine().Trim();

  int estrelas = 0;
  Int32.TryParse(estrelasDigitado, out estrelas);

  if (estrelas < 0 || estrelas > 5)
  {
    Console.WriteLine("A quantidade de estrelas deve ser entre 0 e 5.");
    return;
  }

  var novoContato = new Contato
  {
    Nome = nomeDesejado,
    Fone = fone,
    Estrelas = estrelas,
  };

  using (var agenda = new agendaContext())
  {
    agenda.Contatos.Add(novoContato);
    agenda.SaveChanges();

    Console.WriteLine($"id {novoContato.Id}: Nome: {novoContato.Nome}, Tel: {novoContato.Fone}, {novoContato.Estrelas} estrelas");
  }
}
