public class Transacao
{
    public string Tipo{get;set;}
    public decimal Valor{get;set;}

    public Transacao(string Tipo, decimal valor)
    {
        this.Tipo = Tipo;
        this.Valor = valor;
    }
    public Transacao(){

    }
    public void ExibirDetalhes(){
        System.Console.WriteLine($"Tipo da transação: {Tipo}");
        System.Console.WriteLine($"Valor da transação: {Valor:C}");
        
    }
}