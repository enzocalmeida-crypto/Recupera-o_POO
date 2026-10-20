public class Gerente : Funcionario
{
    private decimal _percentualBonus;

    public decimal PercentualBonus
    {
        get { return _percentualBonus; }
        set { _percentualBonus = value; }
    }

    public Gerente(string nome, string cpf, decimal salarioBase, decimal percentualBonus) :
    base(nome, cpf, salarioBase)
    {
        this.PercentualBonus = percentualBonus;
    }

    public decimal CalcularBonus()
    {
        decimal bonus = (SalarioBase * PercentualBonus) / 100;
        // SalarioBase = ((SalarioBase * PercentualBonus) /100) + SalarioBase;
        return bonus;
    }
}