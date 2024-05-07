// ./Carro.cs

// Classe herdando da Superclasse Veiculo
public class Carro : Veiculo{
    public int NumeroPortas{get;set;}
    
    // Construtor da classe com a base na Superclasse
    public Carro(string Tipo, int Ano, int NumeroPortas) : base(Tipo, Ano){
        this.NumeroPortas = NumeroPortas;
    }

    // Método da classe com a base na Superclasse 
    public void mostrarVeiculo(){
        base.mostrarVeiculo();
        Console.WriteLine("Numero de portas: " + NumeroPortas); 
    }
}