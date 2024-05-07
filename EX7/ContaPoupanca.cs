// ./ContaPoupanca.cs
// Classe herdeira

public class ContaPoupanca : ContaBancaria{
    // Construtor da classe sem novos atributos
    public ContaPoupanca(string titular) : base(titular){}

    // Métodos
    // Mostrar conta
    public void mostrarConta(){
        Console.WriteLine("Conta Poupança");
        base.mostrarConta();
        Console.WriteLine("Juros da conta: " + calcularJuros());
    }

    // Calcular juros da conta
    public double calcularJuros(){
        double TaxaJurosMensal = 0.005;
        double Juros = Saldo * TaxaJurosMensal;
        return Juros;
    }
}