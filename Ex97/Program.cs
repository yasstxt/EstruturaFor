
//Faça um algoritmo que leia um número e imprima a sua tabela de multiplicação de 1 até 13.
int numero;
Console.Write("Digite um número: ");
numero = int.Parse(Console.ReadLine());

for (int i = 1; i <= 13; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}
