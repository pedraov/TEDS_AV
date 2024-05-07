// ./Calculadora2.cs
// Calculadora da Sobreposição

// Classe base  para representar uma forma geométrica (Retangulo)
public class Forma{
    public double largura{get;set;}
    public double altura{get;set;}
    // Método para calcular a área (será sobreposto nas classes derivadas)
    public double calcularArea(){
        return this.largura * this.altura;
    }
}

// Classe que representa um triangulo (herança de Forma)
class Triangulo : Forma{
    // Implementação da sobreposição do método calcularArea para um triangulo
    public double calcularArea(){
        return (this.largura * this.altura) / 2;
    }
}