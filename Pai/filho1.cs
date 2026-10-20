public class ContaCorrente : Conta
{
    public ContaCorrente(
        string titular,
        decimal saldo
    ) : base(titular, saldo)
    {
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException(
                "O valor do saque deve ser maior que zero."
            );
        }

        if (valor > Saldo)
        {
            throw new ArgumentException(
                "Saldo insuficiente para realizar o saque."
            );
        }

        Saldo = Saldo - valor;
    }
}