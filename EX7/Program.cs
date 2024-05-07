// Exercício 7

// Instancia de uma conta corrente
ContaCorrente cc1 = new ContaCorrente("Pedro Victor");
cc1.depositar(100);
cc1.sacar(20);
cc1.mostrarConta();
cc1.verificarSaldoNegativo();

// Quebra de Linha
Console.WriteLine("");

// Instancia de uma conta poupança
ContaPoupanca cp1 = new ContaPoupanca("Whindersson Nunes");
cp1.depositar(1000);
cp1.sacar(100);
cp1.mostrarConta();

// Quebra de Linha
Console.WriteLine("");

//Instancia de uma conta empresarial com valor mínimo abaixo do esperado
ContaEmpresarial ce1 = new ContaEmpresarial("Apple");
ce1.mostrarConta();
ce1.sacar(100);

// Quebra de Linha
Console.WriteLine("");

//Instancia de uma conta empresarial com valor mínimo acima do esperado
ContaEmpresarial ce2 = new ContaEmpresarial("Samsung");
ce2.depositar(2000);
ce2.sacar(200);
ce2.mostrarConta();
