// Exercício 10

// Reserva de voo simples
ReservarVoo reserva1 = new ReservarVoo("Pedro", "123");
reserva1.reservarVoo();

//Quebra de Linha
Console.WriteLine("");

Console.WriteLine(reserva1.obterStatus());

//Quebra de Linha
Console.WriteLine("");

// Reserva de voo com upgrade de classe
ReservarUpgrade reserva2 = new ReservarUpgrade("Maria", "2222", "Econômica", "Primeira Classe");

reserva2.reservarVoo();

//Quebra de Linha
Console.WriteLine("");

reserva2.realizarUpgrade();

//Quebra de Linha
Console.WriteLine("");

Console.WriteLine(reserva2.obterStatus());

//Quebra de Linha
Console.WriteLine("");

// Reserva de voo para grupo grande
ReservarGrupo reserva3 = new ReservarGrupo("Masqueicos", 20, "1234");

reserva3.reservarVoo();

//Quebra de Linha
Console.WriteLine("");

Console.WriteLine(reserva3.obterStatus());

