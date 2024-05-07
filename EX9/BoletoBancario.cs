// ./BoletoBancario.cs

public class BoletoBancario : IMetodoPagamento{
    // Dados do boleto
    public int NumBoleto;
    public bool Pagamento;

    //Construtor da classe
    public BoletoBancario(int num){
        this.NumBoleto = num;
        this.Pagamento = false;
    }

    // Métodos
    // Realizar o pagamento
    public void realizarPagamento(double vlr){
        Console.WriteLine("Valor pago no boleto bancário: "+ vlr);
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