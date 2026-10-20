public class Funcionario
{
    private string _nome = "";
    private string _cpf = "";
    private decimal _salarioBase;

    public string Nome
    {
        get { return _nome; }
        set { _nome = value; }
    }

    public string Cpf
    {
        get { return _cpf; }
        set { _cpf = value; }
    }

    public decimal SalarioBase
    {
        get { return _salarioBase; }
        set { _salarioBase = value; }
    }

    public Funcionario(string nome, string cpf, decimal salarioBase)
    {
        this.Nome = nome;
        this.Cpf = cpf;
        SalarioBase = salarioBase;
    }
}