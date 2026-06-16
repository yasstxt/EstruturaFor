//Escreva um algoritmo que determine o fatorial de um número. Para este problema,
//tem-se como entrada o valor do número do qual se deseja calcular o fatorial.
//O fatorial de 0 é igual a 1. O fatorial de um número N(N!) é definido conforme a seguir: 
//N! = 1 * 2 * 3 * 4 * ... *(N - 1) * N

int numero;
int fatoracao = 1;
Console.Write("Digite um número inteiro: ");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= numero; i++)
{
    fatoracao *= i;
}

Console.WriteLine($"A fatoração de {numero}, deu o valor final de: {fatoracao}");
