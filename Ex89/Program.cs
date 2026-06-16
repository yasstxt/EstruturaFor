using System.ComponentModel.Design;
using System.Security.Cryptography;
//Construa um Algoritmo que, para um grupo de 50 valores inteiros, determine: 
//a) A soma dos números positivos;
//b) A quantidade de valores negativos;
int numero = 0;
int acm = 0;
numero++;
Console.WriteLine($"Digite o {numero}°: ");
Console.ReadLine();

for (numero = 1; numero <= 50; numero++)
{
   if (numero > 0)
    {
        acm = acm + numero;
        Console.Write(numero + ", ");
    } else if (numero < 0)
    {
        acm++;
        Console.Write(numero + ", ");
    }
}
