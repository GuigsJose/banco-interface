public class ContaBancaria : IContaBancaria
{
    public int NumeroConta{get;set;}
    public decimal Saldo{get;set;}

    public ContaBancaria(int numeroConta)
    {
        this.Saldo = 0;
        this.NumeroConta = numeroConta;
    }

    public void Depositar(decimal valor)
    {
        this.Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (Saldo != 0)
        {
            if (valor > Saldo)
            {
                System.Console.WriteLine("Saldo Insuficiente");
            }
            else
            {
                this.Saldo -= valor;
            }
        }
    }
}