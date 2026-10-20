public class ContaPoupanca : Conta
{
    private int _dataAniversarioContaP;

    public int DataAniversarioContaP
    {
        get { return _dataAniversarioContaP; }
        set { _dataAniversarioContaP = value; }
    }

    public void Rendimento(int dataHoje)
    {
        if (DataAniversarioContaP == dataHoje)
        {
            Saldo = (Saldo * 0.07) + Saldo;
            Console.WriteLine($"O saldo com o valor do rendiemnto é {Saldo}");
        }
        else
        {
            Console.WriteLine("Não é a data de rendimento");
        }

    }

    public ContaPoupanca(string nome, double saldo, int dataAniversarioContaP)
    : base(nome, saldo)
    {
        DataAniversarioContaP = dataAniversarioContaP;
    }
}