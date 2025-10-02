
Console.Write("Digite o primeiro valor: ");
double a = double.Parse(Console.ReadLine() ?? "0");

Console.Write("Digite o segundo valor: ");
double b = double.Parse(Console.ReadLine() ?? "0");

double maior = (a > b) ? a : b;

Console.WriteLine($"O maior valor é: {maior}");
Console.WriteLine("Pressione Enter para sair...");
Console.WriteLine();

