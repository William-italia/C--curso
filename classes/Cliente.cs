namespace MeuBanco
{

  class Cliente
  {

    public string Nome { get; set; }

    public string Sobrenome { get; set; }

    public Cliente(string nome, string sobrenome)
    {
      this.Nome = nome;
      this.Sobrenome = sobrenome;
    }
    public string NomeCompleto()
    {
      return $"{this.Nome} {this.Sobrenome}";
    }
  }
}