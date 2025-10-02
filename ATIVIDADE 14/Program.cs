Console.Write("Digite um valor N (maior que 0): ");
int N = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine($"\nNumeros de 1 ate {N}:");
for (int i = 1; i <= N; i++)

    Console.WriteLine(i);

Console.WriteLine("\nPressione Enter para sair...");
Console.ReadLine();