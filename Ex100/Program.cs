//Crie um programa que peça 10 números inteiros e apresente: a média, o maior e o menor. 

int numero;
int maior = 0;
int menor = 0;

for (int i = 1; i <= 10; i++)
{
    Console.Write($"Digite um número: ");
    numero = int.Parse(Console.ReadLine());

    if (i == 1)
    {
        maior = numero;
        menor = numero;
    }

    if (numero > maior)
    {
        maior = numero;
    }

    if (numero < menor)
    {
        menor = numero;
    }
}

Console.WriteLine($"O maior número é: {maior}");
Console.WriteLine($"O menor número é: {menor}");