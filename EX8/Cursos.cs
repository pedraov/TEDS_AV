// ./Cursos.cs
// Superclasse

public class Cursos{
    public string Nome{get;set;}
    public int Duracao{get;set;}
    public bool Conclusao{get;set;}
    public List<double> Notas{get;set;}

    // Construtor da classe
    public Cursos(string Nome, int Duracao){
        this.Nome = Nome;
        this.Duracao = Duracao;
        this.Conclusao = false;
        this.Notas = new List<double>();
    }

    // Métodos
    //Adicionar nota
    public void addNota(double nota){
        Notas.Add(nota);
    }

    // Calcular a média
    public double calcularMedia(){
        if(Notas.Count == 0){
            return 0;
        }else{
            double soma = 0;
            foreach(var nota in Notas){
                soma += nota;
            }
            return soma / Notas.Count;
        }
    }

    // Emitir certificado
    public void emitirCertificado(){
        Console.WriteLine("Curso de " + Nome);
        if(Conclusao){
            Console.WriteLine("Certificado emitido com sucesso.");
        }else{
            Console.WriteLine("Certificado não pode ser emitido, pois curso não foi concluido.");
        }
    }

    // Concluir curso
    public void concluirCurso(){
        Console.WriteLine("Curso de " + Nome);
        if(calcularMedia() > 6){
            if(!Conclusao){
                Conclusao = true;
                Console.WriteLine("Curso concluido com sucesso.");
            }else{
                Console.WriteLine("Curso incompleto.");
            }
        }else{
            Console.WriteLine("Incapaz de concluir o curso por nota");
        }
    }
}