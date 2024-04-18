public class Funcoes
{
   public void ProcessarTransacao(IContaBancaria conta, decimal valor, string tipo)
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
}