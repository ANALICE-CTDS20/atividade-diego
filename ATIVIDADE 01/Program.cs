//declaração de váriaveis

int ValorA = 10;
int ValorB = 20;
int auxiliar = 0;

Console.WriteLine($"o valor ANTERIOR de: A = {ValorA}, B = {ValorB}");

auxiliar = ValorA;
ValorA = ValorB;
ValorB = auxiliar;

Console.WriteLine($"o valor ATUAL de: A = {ValorA}, B = {ValorB}");


