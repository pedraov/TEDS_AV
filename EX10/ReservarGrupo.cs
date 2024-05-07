// ./ReservarGrupo.cs

public class ReservarGrupo : IReserva{
    public string NomeGrupo;
    public int NumeroPessoas;
    public string CodigoVoo;
    public bool Confirmado;

    //Construtor da classe
    public ReservarGrupo(string NomeGrupo, int NumeroPessoas, string CodigoVoo){
        this.NomeGrupo = NomeGrupo;
        this.NumeroPessoas = NumeroPessoas;
        this.CodigoVoo = CodigoVoo;
        this.Confirmado = false;
    }

    //Métodos
    // Reservar Voo
    public void reservarVoo(){
        if(!Confirmado){
            this.Confirmado = true;
            Console.WriteLine("Voo reservado para " + NomeGrupo);
            Console.WriteLine("Código do voo: " + CodigoVoo);
        }else{
            Console.WriteLine("Passageiro já reservou voo.");
        }
    }

    // Cancelar reserva
    public void cancelarReserva(){
        if(Confirmado){
            this.Confirmado = false;
            Console.WriteLine("Voo cancelado para " + NomeGrupo);
            Console.WriteLine("Código do voo: " + CodigoVoo);
        }else{
            Console.WriteLine("Este passageiro não possui voos reservados.");
        }
    }

    // Obter status do voo
    public string obterStatus(){
        if(Confirmado){
            return "Voo confirmado";
        }else{
            return "Voo cancelado";
        }
    }
}