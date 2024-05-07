// ./Moto.cs 

// Classe herdando da Superclasse Veiculo
public class Moto : Veiculo{
    public int Cilindradas{get;set;}

    // Construtor da classe com a base na Superclasse
    public Moto(string Tipo, int Ano, int Cilindradas) : base(Tipo, Ano){
        this.Cilindradas = Cilindradas;
    }
    
    // Método da classe com a base na Superclasse  
    public void mostrarVeiculo(){
        base.mostrarVeiculo();
        Console.WriteLine("Cilindradas: " + Cilindradas);
    }
}