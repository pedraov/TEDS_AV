// ./Bicicleta.cs

// Classe herdando da Superclasse Veiculo
public class Bicicleta : Veiculo{
    public int NumeroMarcha{get;set;}

    // Construtor da classe com a base na Superclasse
    public Bicicleta(string Tipo, int Ano, int NumeroMarcha) : base(Tipo,Ano){
        this.NumeroMarcha = NumeroMarcha;
    }
    
    // Método da classe com a base na Superclasse   
    public void mostrarVeiculo(){
        base.mostrarVeiculo();
        Console.WriteLine("Número de marchas: " + NumeroMarcha);
    }
}