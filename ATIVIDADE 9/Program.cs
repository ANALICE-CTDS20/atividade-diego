
Console.Write("Digite a quantidade de maçãs compradas: ");

int quantidade = int.Parse(Console.ReadLine());

// Se forem menos de 12 maçãs, preço é 1,30. Caso contrário, 1,00.
decimal precoUnitario = (quantidade < 12) ? 1.30m : 1.00m;
decimal total = precoUnitario * quantidade;

Console.WriteLine();
Console.WriteLine($"quantidade: {quantidade}");
Console.WriteLine($"preço unitário: {precoUnitario.ToString("C")}");
Console.WriteLine($"Custo total de compra: {total.ToString("C")}");


Console.WriteLine("\nPressione Enter para sair...");
Console.ReadLine();