// ./ReservarUpgrade.cs

// Classe herdando da classe ReservarVoo
public class ReservarUpgrade : ReservarVoo{
    public string ClasseOriginal;
    public string NovaClasse;
    
    // Construtor da clase com base em ReservarVoo
    public ReservarUpgrade(string Passageiro, string CodigoVoo, string ClasseOriginal, string NovaClasse) : base(Passageiro, CodigoVoo){
        this.ClasseOriginal = ClasseOriginal;
        this.NovaClasse = NovaClasse;
    }
    
    //Métodos
    // Reserva com upgrade
    public void realizarUpgrade(){
        Console.WriteLine("Upgrade realizado para " + NovaClasse + " no voo " + base.CodigoVoo);
    }
}