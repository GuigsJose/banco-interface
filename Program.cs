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


static void ProcessarTransacao(IContaBancaria conta, decimal valor, string tipo)
{
    if (tipo == "Deposito")
        {
            conta.Depositar(valor);
        }
        else if (tipo == "Saque")
        {
            conta.Sacar(valor);
        }
        else
        {
            Console.WriteLine("Tipo de transação inválido.");
        }
    }

ContaCorrente contaC = new ContaCorrente(1234);
ContaPoupanca contaP = new ContaPoupanca(5678);

ProcessarTransacao(contaC,1000, "Deposito");
ProcessarTransacao(contaP,1000, "Deposito");
ProcessarTransacao(contaC,1000, "Saque");
ProcessarTransacao(contaP,1000, "Saque");

Console.WriteLine("Detalhes das transações e saldos:");
System.Console.WriteLine("Conta Corrente:");
contaC.ExibirDetalhes();

System.Console.WriteLine();

System.Console.WriteLine("Conta Poupança:");
contaP.ExibirDetalhes();