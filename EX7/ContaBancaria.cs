// ./ContaBancaria.cs 
// Superclasse

public class ContaBancaria{
    public string Titular{get;set;}
    public double Saldo{get;set;}

    // Construtor da Superclasse
    public ContaBancaria(string Titular){
        this.Titular = Titular;
        this.Saldo = 0;
    }

    // Métodos 
    // Depositar
    public void depositar(double vlr){
        if(vlr > 0){
            this.Saldo += vlr;
        }else{
            Console.WriteLine("Valor incorreto.");
        }
    }

    // Sacar
    public void sacar(double vlr){
        if(vlr > 0){
            if(vlr < Saldo){
                this.Saldo -= vlr;
            }else{
                Console.WriteLine("Valor incorreto.");
            }
        }else{
            Console.WriteLine("Valor incorreto.");
        }
    }

    // Mostrar a conta
    public void mostrarConta(){
        Console.WriteLine("Titular: " + Titular);
        Console.WriteLine("Saldo: " + Saldo);
    }
}