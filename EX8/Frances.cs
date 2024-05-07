// ./Frances.cs
// Classe herdando da Superclasse

public class Frances : Cursos{
    // Construtor sem novos argumentos
    public Frances(int Duracao) : base("Francês", Duracao){}

    // Métodos
    // Adicionar nota com herança da Superclasse
    public void addNota(double nota){
        base.addNota(nota);
    }
    
    // Calcular média com herança da Superclasse
    public void calcularMedia(){
        if(Duracao > 3){
            Console.WriteLine("Média final: "+ base.calcularMedia());
        }else{
            Console.WriteLine("Curso não avançado, média não pode ser calculada.");
        }
    }

    // Emitir certificado com herança da Superclasse
    public void emitirCertificado(){
        base.emitirCertificado();
    }

    // Concluir curso com herança da Superclasse
    public void concluirCurso(){
        base.concluirCurso();
    }
}