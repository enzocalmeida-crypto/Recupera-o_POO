public class Conta
{
    private string _nome = "";
    private double _saldo;

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public double Saldo
    {
        get { return _saldo; }
        set { _saldo = value; }
    }

    public Conta(string nome, double saldo)
    {
        Nome = nome;
        Saldo = saldo;
    }
}