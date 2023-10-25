using System;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string? nome;
string? telefone;
string? profissao;
string? email;
string? descricao;

// Solicita as informações do cartão
Console.WriteLine("Digite o nome do seu cartão de visita");
nome = Console.ReadLine();

Console.WriteLine("Profissão");
profissao = Console.ReadLine();


Console.WriteLine("Digite seu telefone");
telefone = Console.ReadLine();

Console.WriteLine("Digite seu email");
email = Console.ReadLine();

Console.WriteLine("Digite sua mensagem de descrição");
descricao = Console.ReadLine();


//Prospecto do cartão

Console.WriteLine("|-------------------------------|");
Console.WriteLine("|" + nome + "  |");
Console.WriteLine("|" + profissao + "  |");
Console.WriteLine("| Tele:" + telefone + "|");
Console.WriteLine("| Email: " + email + " |");
Console.WriteLine("|  " + descricao + " | ");
Console.WriteLine("|-------------------------------|");