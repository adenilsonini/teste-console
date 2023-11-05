// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe seu Nome ?");


var nome = Console.ReadLine();

Console.WriteLine("Informe a idade ?");

var idade = Convert.ToInt32(Console.ReadLine());

if (nome == "joao" || idade >= 18)
{
     Console.WriteLine($"Seu nome é: {nome} você é maior de idade");
} else
{
    Console.WriteLine("O nome digitado não é joao !");
}

