// See https://aka.ms/new-console-template for more information


using Conceitos;

// # CLIENTE

Console.WriteLine("Bem vindo ao seu perfil no Nubank!");


Console.WriteLine("Informe o nome do cliente");
string nome = Console.ReadLine();


Console.WriteLine("Informe o cpf do cliente");
string cpf = Console.ReadLine();


Cliente cliente = new Cliente(nome,cpf);


Console.WriteLine($"Olá {cliente.Nome} !");
Console.WriteLine($"Seu cpf é : {cliente.Cpf} !");


// AGENCIA

Agencia agencia = new Agencia(2087); // Metodo construtor pois tem o mesmo nome da classe


Console.WriteLine($"Sua agencia é : {agencia.Numero}");

agencia.Nome = "Conta Corrente";
Console.WriteLine($"Sua conta é do tipo : {agencia.Nome}");

agencia.Telefone = "24992778679";
Console.WriteLine($"Seu numero de telefone é : {agencia.Telefone}");

Console.WriteLine("Obrigado pela consulta!");



// # CONTA

Conta conta = new Conta(12,0);
Console.WriteLine($"O numero da sua conta é {conta.Numero}");
Console.WriteLine($"O saldo da sua conta é {conta.Saldo}");








