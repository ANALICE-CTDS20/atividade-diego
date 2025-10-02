
Console.Write("Ano Atual: ");
int anoAtual = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Ano de nascimento: ");
int anoNascimento = int.Parse(Console.ReadLine() ?? "0");

int idade = anoAtual - anoNascimento;

Console.WriteLine($"Idade: {idade} anos.");

if (idade < 16)
    Console.WriteLine("Resultado: Não pode votar este ano.");
else if (idade == 16 || idade == 17)
    Console.WriteLine("Resultado: Voto facultativo.");
else if (idade >= 18 && idade <= 69)
    Console.WriteLine("Resultado: Voto obrigatorio.");
else // idade >= 70
    Console.WriteLine();

Console.WriteLine("Pressione Enter para sair...");
Console.ReadLine();