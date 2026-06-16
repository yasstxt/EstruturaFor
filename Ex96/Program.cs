//Escreva um algoritmo que calcule o produto dos inteiros ímpares de 1 a 15 e, então, exiba os resultados.

int produto = 1;

for (int i = 1; i <= 15; i += 2)
{
    produto *= i;
}

Console.WriteLine($"O produto dos números ímpares de 1 a 15 é: {produto}");