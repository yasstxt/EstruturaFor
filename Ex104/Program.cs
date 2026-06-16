//Sem utilizar a operação de multiplicação, escreva um programa que multiplique dois números inteiros. Por exemplo: 2 * 2 = 2 + 2.

int total;
int numero;
Console.WriteLine("Digite um número inteiro para multiplicar por ele mesmo: ");
numero = int.Parse(Console.ReadLine());

for (int numeros = 0; numeros <= 0; numero++)
{
    total = numero + numero;
    Console.WriteLine($"{numero} x {numero} = {total}");
}


