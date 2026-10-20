public class ContaPoupanca : Conta
{
    private int _diaAniversario;
    private decimal _taxaRendimento;

    public int DiaAniversario
    {
        get
        {
            return _diaAniversario;
        }

        set
        {
            if (value < 1 || value > 31)
            {
                throw new ArgumentException(
                    "O dia de aniversário deve estar entre 1 e 31."
                );
            }

            _diaAniversario = value;
        }
    }

    public decimal TaxaRendimento
    {
        get
        {
            return _taxaRendimento;
        }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    "A taxa de rendimento não pode ser negativa."
                );
            }

            _taxaRendimento = value;
        }
    }

    public ContaPoupanca(
        string titular,
        decimal saldo,
        int diaAniversario,
        decimal taxaRendimento
    ) : base(titular, saldo)
    {
        this.DiaAniversario = diaAniversario;
        this.TaxaRendimento = taxaRendimento;
    }

    public void AplicarRendimento(int diaAtual)
    {
        if (diaAtual == DiaAniversario)
        {
            decimal rendimento =
                Saldo * TaxaRendimento / 100;

            Saldo = Saldo + rendimento;
        }
    }
}