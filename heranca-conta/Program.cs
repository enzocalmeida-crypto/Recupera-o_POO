Console.WriteLine("CONTA CORRENTE");

ContaCorrente contaCorrente =
    new ContaCorrente(
        "Carlos",
        1000
    );

Console.WriteLine($"Titular: {contaCorrente.Nome}");

Console.WriteLine( $"Saldo inicial: R$ {contaCorrente.Saldo:F2}");


Console.WriteLine("Saque igual ao saldo:");
contaCorrente.Saque(1000);

Console.WriteLine($"Saldo após saque: R$ {contaCorrente.Saldo:F2}");



ContaCorrente contaCorrente2 =
    new ContaCorrente(
        "Carlos",
        1000
    );

Console.WriteLine("Saque maior que o saldo:");
contaCorrente2.Saque(1500);

Console.WriteLine($"Saldo após tentativa: R$ {contaCorrente2.Saldo:F2}");

Console.WriteLine("Saque menor que o saldo:");
contaCorrente2.Saque(300);

Console.WriteLine($"Saldo após saque: R$ {contaCorrente2.Saldo:F2}");

Console.WriteLine();

Console.WriteLine("CONTA POUPANÇA");

ContaPoupanca contaPoupanca =
    new ContaPoupanca(
        "Maria",
        2000,
        15
    );

Console.WriteLine($"Titular: {contaPoupanca.Nome}");

Console.WriteLine($"Saldo inicial: R$ {contaPoupanca.Saldo:F2}");


Console.WriteLine("Testando rendimento na data correta:");
contaPoupanca.Rendimento(15);

Console.WriteLine($"Saldo após rendimento: R$ {contaPoupanca.Saldo:F2}");


Console.WriteLine("Testando rendimento em outra data:");
contaPoupanca.Rendimento(20);

Console.WriteLine($"Saldo final: R$ {contaPoupanca.Saldo:F2}");