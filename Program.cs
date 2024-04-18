// Console.WriteLine("FUNCIONOU");

// // TESTE
// // ContaBancaria cb = new ContaBancaria(1223);

// // cb.Depositar(10000);
// // Console.WriteLine($"Numero da conta: {cb.NumeroConta}");Console.WriteLine(cb.Saldo);

// // CRIANDO CONTA POUPANÇA
// ContaPoupanca cp = new ContaPoupanca(1235);
// Console.WriteLine("Conta Poupança");
// cp.Depositar(2039);
// Console.WriteLine($"Saldo atual {cp.Saldo}");
// cp.Sacar(1000);
// Console.WriteLine($"Saldo atualizado: {cp.Saldo}");

// // CRIANDO CONTA CORRENTE
// Console.WriteLine();
// Console.WriteLine("Conta Corrente");
// ContaCorrente cr = new ContaCorrente(9876);
// Console.WriteLine($"Saldo Atual: {cr.Saldo}");
// cr.Depositar(1200);
// Console.WriteLine($"Saldo atualizado: {cr.Saldo}");
// cr.Sacar(200);
// Console.WriteLine($"Saldo atualizado: {cr.Saldo}");

// cr.TransacaoConta(cp,50);

// Console.WriteLine(cr.Saldo);
// Console.WriteLine(cp.Saldo);

// contaC.Depositar(1000);
// contaP.Depositar(3289);
// contaC.Sacar(34);
// contaP.Depositar(76);

// contaC.TransacaoConta(contaP,90);

// Console.WriteLine("Detalhes das transações e saldos:");
// System.Console.WriteLine("Conta Corrente:");
// contaC.ExibirDetalhes();

// System.Console.WriteLine();

// System.Console.WriteLine("Conta Poupança:");
// contaP.ExibirDetalhes();


Funcoes f = new Funcoes();

ContaCorrente contaC = new ContaCorrente(1234);
ContaPoupanca contaP = new ContaPoupanca(5678);

f.ProcessarTransacao(contaC,1000, "Deposito");
f.ProcessarTransacao(contaP,1000, "Deposito");
f.ProcessarTransacao(contaC,200, "Deposito");
f.ProcessarTransacao(contaP,300, "Deposito");
contaC.TransacaoConta(contaP,200);

Console.WriteLine("Detalhes das transações e saldos:");
System.Console.WriteLine("Conta Corrente:");
contaC.ExibirDetalhes();

System.Console.WriteLine();

System.Console.WriteLine("Conta Poupança:");
contaP.ExibirDetalhes();