// Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos e semanas

// algorismo 
// entrada: ano de nascimento da pessoa
// processamento: ano de nascimento menos o ano em que estamos e depois multiplicar o resultado pelo numero de semanas que tem um ano

Console.BackgroundColor = ConsoleColor.DarkRed;
Console.WriteLine(@$"
Programinha para calcular sua idade a partir do ano em que você nasceu.
");
Console.ResetColor();

Console.WriteLine($"Digite seu ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine());

int idade = DateTime.Now.Year - anoNascimento;
Console.WriteLine($"sua idade é: {idade}");

int semanas = anoNascimento * 52;
Console.WriteLine($"sua idade em semanas é: {semanas}");


