// Exercício 8
// NOTA: Não entendi bem essa questão, porém acredito que seja isso que tenha sido proposto no enunciado.

Cursos curso1 = new Ingles(12);
Cursos curso2 = new Espanhol(8);
Cursos curso3 = new Frances(6);

// Adicionando nota aos cursos
curso1.addNota(7.5);
curso1.addNota(8.0);

curso2.addNota(6.0);
curso2.addNota(7.0);
curso2.addNota(6.5);

curso3.addNota(2.5);
curso3.addNota(5.5);

// Calculando a média do aluno em inglês
Console.WriteLine("Nota do Curso de Inglês: " + curso1.calcularMedia());

// Quebra de linha
Console.WriteLine("");

// Calculando a nota do aluno em espanhol
Console.WriteLine("Nota do Curso de Espanhol: " + curso2.calcularMedia());

// Quebra de linha
Console.WriteLine("");

// Calculando a nota do alno em francês
Console.WriteLine("Nota do Curso de Francês: " + curso3.calcularMedia());

// Quebra de linha
Console.WriteLine("");



// Concluir cursos
curso1.concluirCurso();

// Quebra de linha
Console.WriteLine("");

curso2.concluirCurso();

// Quebra de linha
Console.WriteLine("");

curso3.concluirCurso();

// Quebra de linha
Console.WriteLine("");



// Emitir certificados
curso1.emitirCertificado();

// Quebra de linha
Console.WriteLine("");

curso2.emitirCertificado();

// Quebra de linha
Console.WriteLine("");

curso3.emitirCertificado();
