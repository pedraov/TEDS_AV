// ./ReservarVoo.cs

public class ReservarVoo : IReserva{
    public string Passageiro;
    public string CodigoVoo;
    public bool Confirmado;

    // Construtor da classe
    public ReservarVoo(string Passageiro, string CodigoVoo){
        this.Passageiro = Passageiro;
        this.CodigoVoo = CodigoVoo;
        this.Confirmado = false;
    }

    // Métodos 
    // Reservar voo
    public void reservarVoo(){
        if(!Confirmado){
            this.Confirmado = true;
            Console.WriteLine("Voo reservado para " + Passageiro);
            Console.WriteLine("Código do voo: " + CodigoVoo);
        }else{
            Console.WriteLine("Passageiro já reservou voo.");
        }
    }

    // Cancelar reserva
    public void cancelarReserva(){
        if(Confirmado){
            this.Confirmado = false;
            Console.WriteLine("Voo cancelado para " + Passageiro);
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