// ./Veiculo.cs (Super classe)

public class Veiculo{
    public string Tipo{get;set;}
    public int Ano{get;set;}

    // Construtor da classe
    public Veiculo(string Tipo, int Ano){
        this.Tipo = Tipo;
        this.Ano = Ano;
    }

    //Método para mostrar veiculo
    public void mostrarVeiculo(){
        Console.WriteLine("Tipo: "+ Tipo + " / Ano: "+ Ano);
    }
}