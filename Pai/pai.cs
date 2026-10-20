public class Conta
{
    private string _titular;
    private decimal _saldo;
    
     public Conta(string titular, decimal saldo)
    {
        this.Titular = titular;
        this.Saldo = saldo;
    }

    public string Titular
    {
        get
        {
            return _titular;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(
                    "O titular não pode ficar vazio."
                );
            }

            _titular = value.Trim();
        }
    }

    public decimal Saldo
    {
        get
        {
            return _saldo;
        }

        protected set
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    "O saldo não pode ser negativo."
                );
            }

            _saldo = value;
        }
    }
   
}