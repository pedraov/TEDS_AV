// ./Produto.cs

// Classe Produto
public class Produto{
    public string Nome{get;set;}
    public double Preco{get;set;}
    public int QuantidadeEmEstoque{get;set;}

    // Construtor da classe
    public Produto(string Nome, double Preco, int QuantidadeEmEstoque){
        this.Nome = Nome;
        this.Preco = Preco;
        this.QuantidadeEmEstoque = QuantidadeEmEstoque;
    }

    // Métodos

    // Adicionar estoque
    public void addEstoque(int vlr){
        if(vlr > 0){
            this.QuantidadeEmEstoque += vlr;
            Console.WriteLine("Quantidade em estoque: " + QuantidadeEmEstoque);
        }else{
            Console.WriteLine("Quantidade não pode ser negativa ou zero");
        }
    }
    // Remover estoque
    public void removerEstoque(int vlr){
        if(vlr > 0 && QuantidadeEmEstoque >= vlr){
            this.QuantidadeEmEstoque -= vlr;
            Console.WriteLine("Quantidade em estoque: "+ QuantidadeEmEstoque);
        }else{
            Console.WriteLine("Quantidade em estoque insuficiente");
        }
    }
    // Calcular estoque
    public double calcularEstoque(){
        return QuantidadeEmEstoque * Preco;
    }
}