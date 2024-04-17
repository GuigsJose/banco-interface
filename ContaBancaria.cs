public class ContaBancaria : IContaBancaria
{
    public int NumeroConta{get;set;}
    public decimal Saldo{get;set;}
    public List<Transacao> transacaos = new List<Transacao>();
    public ContaBancaria(int numeroConta)
    {
        this.Saldo = 0;
        this.NumeroConta = numeroConta;
    }

    public void TransacaoConta(ContaBancaria contaDestino, decimal valor)
    {
       Sacar(valor);
       contaDestino.Depositar(valor); 
    }

    public void Depositar(decimal valor)
    {
        this.Saldo += valor;
        Transacao tr = new Transacao("Depósito", valor);
        transacaos.Add(tr);
    }

    public void Sacar(decimal valor)
    {
        {
            if (valor <= Saldo)
            {
                 this.Saldo -= valor;

                Transacao tr = new Transacao("Saque", valor);
                transacaos.Add(tr);
            }
            else
            {
               System.Console.WriteLine("Saldo insuficiente");
            }
        }
    }

    public void ExibirDetalhes()
    {   
        System.Console.WriteLine($"Número da Conta: {NumeroConta}");
        System.Console.WriteLine($"Saldo Atual: {Saldo:F2}");
        System.Console.WriteLine("Transações: ");
        foreach(Transacao transacao in transacaos)
        {
            transacao.ExibirDetalhes();
        }
    }
}