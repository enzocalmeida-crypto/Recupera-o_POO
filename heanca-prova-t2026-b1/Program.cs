Vendedor vendedor = new Vendedor("Carlos", "12345678900", 2500m, 10000m, 5m);

Gerente gerente = new Gerente("Ana", "98765432100", 8000m, 10m);

decimal comissao = vendedor.CalcularComissao();

decimal bonus = gerente.CalcularBonus();

Console.WriteLine("VENDEDOR");
Console.WriteLine($"Nome: {vendedor.Nome}");
Console.WriteLine($"Salário base: R$ {vendedor.SalarioBase:F2}");
Console.WriteLine($"Total de vendas: R$ {vendedor.TotalVendas:F2}");
Console.WriteLine($"Comissão: R$ {comissao:F2}");

Console.WriteLine();

Console.WriteLine("GERENTE");
Console.WriteLine($"Nome: {gerente.Nome}");
Console.WriteLine($"Salário base: R$ {gerente.SalarioBase:F2}");
Console.WriteLine($"Bônus: R$ {bonus:F2}");