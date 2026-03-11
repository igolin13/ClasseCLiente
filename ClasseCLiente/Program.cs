// See https://aka.ms/new-console-template for more information


using Conceitos;
using static System.Runtime.InteropServices.JavaScript.JSType;

// # CLIENTE

Console.WriteLine("Bem vindo ao seu perfil no Nubank!");


Console.WriteLine("Informe o nome do cliente");
string nome = Console.ReadLine();


Console.WriteLine("Informe o cpf do cliente");
string cpf = Console.ReadLine();


Cliente cliente = new Cliente(nome,cpf);


Console.WriteLine($"Olá {cliente.Nome} !");



Console.WriteLine();
Console.WriteLine();





// AGENCIA

Agencia agencia = new Agencia(2087); // Metodo construtor pois tem o mesmo nome da classe

Console.WriteLine($"Olá {cliente.Nome} !");
Console.WriteLine($"Sua agencia é : {agencia.Numero}");

agencia.Nome = "Conta Corrente";
Console.WriteLine($"Sua conta é do tipo : {agencia.Nome}");

agencia.Telefone = "24992778679";
Console.WriteLine($"Seu numero de telefone é : {agencia.Telefone}");


Console.WriteLine();
Console.WriteLine();


// # CONTA



Console.WriteLine("Digite o numero da sua conta");
long numero = long.Parse(Console.ReadLine());

Console.WriteLine("Digite o saldo inicial da sua conta");
decimal saldoin = decimal.Parse(Console.ReadLine());


Conta conta = new Conta(numero, saldoin);




Console.WriteLine($"Seu saldo é : {saldoin}");



conta.Deposito(1000);

Console.WriteLine($"Seu saldo é : {saldoin}");

conta.Saque(500);

Console.WriteLine($"Seu saldo é : {saldoin}");








