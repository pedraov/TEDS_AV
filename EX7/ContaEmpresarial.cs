// ./ContaEmpresarial.cs
// Classe herdeira

public class ContaEmpresarial : ContaBancaria{
    // Construtor da classe sem novos atributos
    public ContaEmpresarial(string Titular) : base(Titular){}

    // Métodos
    // Mostrar conta
    public void mostrarConta(){
        Console.WriteLine("Conta Empresarial");
        base.mostrarConta();
        Console.WriteLine("Saldo mínimo requerido: R$ 1500.00");
    }

    // Verificar saldo mínimo
    public bool saldoMinino(double vlr){
        if(base.Saldo < vlr){
            Console.WriteLine("Saldo mínimo não atingido.");
            return false;
        }else{
            Console.WriteLine("Saldo mínimo atingido.");
            return true;
        }
    }

    // Método para sacar de uma conta empresarial (Sobreescrevendo o método da Super classes)
    public void sacar(double vlr){
        if(saldoMinino(1500)){
            base.sacar(vlr);
        }
    }
}