//Sem utilizar a operação de multiplicação, escreva um programa que multiplique dois números inteiros.
//Por exemplo: 2 * 2 = 2 + 2.

int total = 0;
int numero1, numero2;
Console.WriteLine("Digite um número inteiro para multiplicar: ");
numero1 = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número inteiro para multiplicar: ");
numero2 = int.Parse(Console.ReadLine());


for (int i = 1; i <= numero2; i++)
{
    total += numero1;
}

Console.WriteLine($"{numero1} x {numero2} = {total}");

