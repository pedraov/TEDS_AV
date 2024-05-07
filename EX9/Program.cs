// Exercício 9

// Instanciando metodos de pagamento
IMetodoPagamento m1 = new CartaoCredito(1111112, "Pedro Victor", 124);
IMetodoPagamento m2 = new BoletoBancario(221212121);
IMetodoPagamento m3 = new TransferenciaBancaria("Conta pagadora 1", "Conta destino 1");

//Realizando pagamentos
m1.realizarPagamento(200);
m2.realizarPagamento(450);

//Quebra de Linha
Console.WriteLine("");

//Verificando pagamentos
Console.WriteLine(m1.verificarPagamento());
//Quebra de Linha
Console.WriteLine("");
Console.WriteLine(m2.verificarPagamento());
//Quebra de Linha
Console.WriteLine("");
Console.WriteLine(m3.verificarPagamento()); //Retorno falso