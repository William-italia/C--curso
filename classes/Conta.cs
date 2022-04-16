namespace MeuBanco
{

  class Conta
  {
    private string _titular;
    private decimal _saldo;
    public Cliente Titular { get; private set; }
    public decimal Saldo
    {
      get
      {
        return this._saldo;
      }
      private set
      {
        if (value < 0)
        {
          throw new ArgumentException("Saldo Inválido.");
        }
        this._saldo = value;
      }
    }

    public Conta(Cliente titular, decimal saldo)
    {
      this.Titular = titular;
      this.Saldo = saldo;
    }

    public void Depositar(decimal valorADepositar)
    {
      if (valorADepositar <= 0)
      {
        throw new ArgumentException("Depósitos devem ser posítivos");
      }
      this.Saldo += valorADepositar;
    }

    public bool Sacar(decimal ValorASacar)
    {
      if (ValorASacar <= 0)
      {
        throw new ArgumentException("Saques devem ser positivos");
      }

      bool possuiSaldo = (this.Saldo >= ValorASacar);
      if (possuiSaldo)
      {
        this.Saldo -= ValorASacar;
      }
      return possuiSaldo;
    }
  }
}