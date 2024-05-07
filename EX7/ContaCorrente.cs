// ./ContaCorrente.cs
// Classe herdeira

public class ContaCorrente : ContaBancaria{
    // Construtor da classe sem novos atributos
    public ContaCorrente(string Titular) : base(Titular){}

    // Métodos
    // Mostrar conta
    public void mostrarConta(){
        Console.WriteLine("Conta Corrente");
        base.mostrarConta();
    }
    
    //Verificar saldo negativo
    // NOTA: Como você só pode sacar se o saldo for maior que 0 esse método se torna obsoleto, dando apenas um retorno.
    // Porém este foi o único método que consegui pensar para esta classe.
    public void verificarSaldoNegativo(){
        if(base.Saldo < 0){
            Console.WriteLine("Saldo Negativo.");
        }else{
            Console.WriteLine("Saldo Positivo.");
        }
    }
}