// Faça um algoritmo que imprima os múltiplos positivos de 7, inferiores a 1000.
using System.ComponentModel.Design;
using System.Security.Cryptography;
int acm = 0;
for (int numero = 0; numero <= 1000; numero++)
{
    if (numero < 100 && numero > 0)
    acm = acm + 7;
    Console.Write(numero);
}
