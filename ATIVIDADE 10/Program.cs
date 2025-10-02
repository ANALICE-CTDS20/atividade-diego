
Console.WriteLine("Exercício 10 - Média de avaliaçoes");

// Ler nota 1
Console.Write("Digite a nota da 1 avaliação: ");
double nota1 = double.Parse(Console.ReadLine());

// Ler nota 2
Console.Write("Digite a nota 2 avaliação: ");
double nota2 = double.Parse(Console.ReadLine());

// Calcular média
double media = (nota1 + nota2) / 2.0;


Console.WriteLine();
Console.WriteLine($"Nota 1: {nota1}");
Console.WriteLine($"Nota 2: {nota2}");
Console.WriteLine($"Média: {media:F2}");

// Verificar aprovação
if (media >= 6.0)

    Console.WriteLine("Aluno aprovado!");
else
    Console.WriteLine("Aluno não aprovado.");

Console.WriteLine("\nPressione Enter para sair...");
Console.ReadLine();