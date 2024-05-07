// Exercício 5

// Instancia dos filmes
Filmes filme1 = new Filmes("Star Wars: Episódio III - A Vingança dos Sith (2005)", "Ficção Científica", 140);

Filmes filme2 = new Filmes("Todo Mundo Em Pânico", "Comédia", 88);

// Locação do primeiro filme
filme1.locarFilme();

//Quebra de Linha
Console.WriteLine();

// Locação do primeiro filme (retorno falso)
filme1.locarFilme();

//Quebra de Linha
Console.WriteLine();

// Devolução do segundo filme (retorno falso)
filme2.devolverFilme();

//Quebra de Linha
Console.WriteLine();

// Locação do segundo filme
filme2.locarFilme();

//Quebra de Linha
Console.WriteLine();

// Devolução do primeiro filme
filme1.devolverFilme();

//Quebra de Linha
Console.WriteLine();

//Disponibilidade do segundo filme (retorno falso)
filme2.disponibilidadeFilme();

//Quebra de Linha
Console.WriteLine();

//Disponibilidade do primeiro filme
filme1.disponibilidadeFilme();