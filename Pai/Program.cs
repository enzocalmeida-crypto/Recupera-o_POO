Console.WriteLine("CONTA CORRENTE");

ContaCorrente contaCorrente =
    new ContaCorrente(
        "Carlos",
        1000m
    );

Console.WriteLine(
    $"Titular: {contaCorrente.Titular}"
);

Console.WriteLine(
    $"Saldo inicial: R$ {contaCorrente.Saldo:F2}"
);

contaCorrente.Sacar(300m);

Console.WriteLine(
    $"Saldo após saque: R$ {contaCorrente.Saldo:F2}"
);


Console.WriteLine();
Console.WriteLine("CONTA POUPANÇA");

ContaPoupanca contaPoupanca =
    new ContaPoupanca(
        "Maria",
        2000m,
        15,
        1m
    );

Console.WriteLine(
    $"Titular: {contaPoupanca.Titular}"
);

Console.WriteLine(
    $"Saldo inicial: R$ {contaPoupanca.Saldo:F2}"
);

contaPoupanca.AplicarRendimento(15);

Console.WriteLine(
    $"Saldo após rendimento: R$ {contaPoupanca.Saldo:F2}"
);