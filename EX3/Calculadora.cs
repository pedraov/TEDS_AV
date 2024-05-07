// ./Calculadora.cs
// Calculadora da Sobrecarga

public class Calculadora{
    //Método para calcular dois números
    public int somar(int a, int b, int c){
        return a + b + c;
    }

    // Método sobrecarregado somando três números
    public int somar(int a, int b){
        return a + b;
    }
}