// ./CartaoCredito.cs

public class CartaoCredito : IMetodoPagamento{
    // Dados do cartão
    public int Cartao;
    public string Titular;
    public int CVV;
    public bool Pagamento;

    //Construtor da classe
    public CartaoCredito(int Cartao, string Titular, int CVV){
        this.Cartao = Cartao;
        this.Titular = Titular;
        this.CVV = CVV;
        this.Pagamento = false;
    }

    // Métodos
    // Realizar o pagamento
    public void realizarPagamento(double vlr){
        Console.WriteLine("Valor pago no cartão de crédito: "+ vlr);
        Console.WriteLine("Pagamento realizado com sucesso.");
        this.Pagamento = true;
    }

    // Verificar pagamento
    public string verificarPagamento(){
        if(Pagamento){
            return "Pagamento realizado com cartão de crédito.";
        }else{
            return "Pagamento não realizado.";
        }
    }
}