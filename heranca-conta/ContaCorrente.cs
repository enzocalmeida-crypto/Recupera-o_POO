public class ContaCorrente : Conta
{
    public ContaCorrente(string nome, double saldo) : base(nome, saldo) { }

    public double Saque(double valorDebito)
    {
        if (Saldo >= valorDebito)
        {
            Saldo = Saldo - valorDebito;
            Console.WriteLine($"O saldo atual é {Saldo}");
            return Saldo;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente!!");
            return 0;
        }
    }
}