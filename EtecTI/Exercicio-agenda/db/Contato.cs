
namespace Exercicio_agenda.db
{
  public partial class Contato
  {
    public int Id { get; set; }
    public string Nome { get; set; } = null!;
    public string? Fone { get; set; }
    public int? Estrelas { get; set; }
  }
}
