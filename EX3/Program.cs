// Exercício 3

// Sobrecarga: Permite ter vários métodos com o mesmo nome em uma classe, mas com assinaturas diferentes (número ou tipo de parâmetros).
Console.WriteLine("Sobrecarga");

//Instancia da calculadora
Calculadora calc = new Calculadora();

//Impressão dos calculos
Console.WriteLine(calc.somar(1,1,1));

//Quebra de Linha
Console.WriteLine();

// Sobrecarga dos calculos
Console.WriteLine(calc.somar(1,1));


//Quebra de Linha
Console.WriteLine();


// Sobreposição: Permite que uma classe derivada forneça uma implementação específica para um método que já foi definido em sua classe base, 
// substituindo o comportamento padrão.
Console.WriteLine("Sobreposição");
//Criando uma instância de uma forma
Forma forma = new Forma();
forma.altura = 20;
forma.largura = 40;

//Calculando e exibindo a área de uma forma qualquer
Console.WriteLine(forma.calcularArea());

//Quebra de Linha
Console.WriteLine();

// Criando uma instância de um triângulo
Triangulo tri = new Triangulo();
tri.altura = 20;
tri.largura = 20;

// Calculando e exibindo a área do triângulo
Console.WriteLine(tri.calcularArea());