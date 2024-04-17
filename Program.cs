Console.WriteLine("FUNCIONOU");

// TESTE
// ContaBancaria cb = new ContaBancaria(1223);

// cb.Depositar(10000);
// Console.WriteLine($"Numero da conta: {cb.NumeroConta}");Console.WriteLine(cb.Saldo);

// CRIANDO CONTA POUPANÇA
ContaPoupanca cp = new ContaPoupanca(1235);
Console.WriteLine("Conta Poupança");
cp.Depositar(2039);
Console.WriteLine($"Saldo atual {cp.Saldo}");
cp.Sacar(1000);
Console.WriteLine($"Saldo atualizado: {cp.Saldo}");

// CRIANDO CONTA CORRENTE
Console.WriteLine();
Console.WriteLine("Conta Corrente");
ContaCorrente cr = new ContaCorrente(9876);

Console.WriteLine($"Saldo Atual: {cr.Saldo}");
cr.Depositar(1200);
Console.WriteLine($"Saldo atualizado: {cr.Saldo}");
cr.Sacar(200);
Console.WriteLine($"Saldo atualizado: {cr.Saldo}");