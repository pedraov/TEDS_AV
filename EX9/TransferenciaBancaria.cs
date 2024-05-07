// ./TransferenciaBancaria.cs

public class TransferenciaBancaria : IMetodoPagamento{
    // Dados da transferencia
    public string ContaPagadora;
    public string ContaDestino;
    public bool Pagamento;

    // Construtor da classe
    public TransferenciaBancaria(string ContaPagadora, string ContaDestino){
        this.ContaPagadora = ContaPagadora;
        this.ContaDestino = ContaDestino;
        this.Pagamento = false;
    }
    
    // Métodos
    // Realizar pagamento
    public void realizarPagamento(double vlr){
        Console.WriteLine("Valor pago por transferência bancária: "+ vlr);
        Console.WriteLine("Pagamento realizado com sucesso.");
        this.Pagamento = true;
    }

    // Verificar pagamento
    public string verificarPagamento(){
        if(Pagamento){
            return "Pagamento realizado com boleto bancário.";
        }else{
            return "Pagamento não realizado.";
        }
    }
}