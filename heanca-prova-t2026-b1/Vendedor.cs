public class Vendedor : Funcionario
{
    private decimal _totalVendas;
    private decimal _percentualComissao;

    public decimal TotalVendas
    {
        get { return _totalVendas; }
        set { _totalVendas = value; }
    }

    public decimal PercentualComissao
    {
        get { return _percentualComissao; }
        set { _percentualComissao = value; }
    }

    public Vendedor(string nome, string cpf, decimal salarioBase, decimal totalVendas, decimal percentualComissao
    ) : base(nome, cpf, salarioBase)
    {
        this.TotalVendas = totalVendas;
        this.PercentualComissao = percentualComissao;
    }

    public decimal CalcularComissao()
    {
        decimal comissao = (TotalVendas * PercentualComissao) / 100;
        return comissao;
    }
}