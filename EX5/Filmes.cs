// ./Filmes

public class Filmes{
    public string Titulo{get;set;}
    public string Genero{get;set;}
    public int DuracaoMin{get;set;}
    public bool Disponivel{get;set;}

    // Construtor da classe
    public Filmes(string Titulo, string Genero, int DuracaoMin){
        this.Titulo = Titulo;
        this.Genero = Genero;
        this.DuracaoMin = DuracaoMin;
        this.Disponivel = true;
    }

    // Métodos
    // Método para locar filme
    public void locarFilme(){
        if(Disponivel){
            Disponivel = false;
            Console.WriteLine("Filme: " + Titulo + " (" + Genero + " / " + DuracaoMin + " Minutos" + "), Locado com sucesso.");
        }else{
            Console.WriteLine("Filme: " + Titulo + " indisponível para locação.");
        }
    }

    // Método para devolver filme
    public void devolverFilme(){
        if(!Disponivel){
            Disponivel = true;
            Console.WriteLine("Filme: " + Titulo + " (" + Genero + " / " + DuracaoMin + " Minutos" + "), Devolvido com sucesso.");
        }else{
            Console.WriteLine("Filme: " + Titulo + " não pode ser devolvido, pois não foi locado.");
        }
    }

    // Método para verificar disponibilidade do filme
    public void disponibilidadeFilme(){
        if(Disponivel){
            Console.WriteLine("Filme: " + Titulo + " disponível para locação.");
        }else{
            Console.WriteLine("Filme: " + Titulo + " indisponível para locação.");
        }
    }
}