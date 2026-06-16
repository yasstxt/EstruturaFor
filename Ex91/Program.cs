//Faça um algoritmo que imprima todos os números pares compreendidos entre 
//85 e 907. O algoritmo deve também calcular a soma destes valores. 

int total = 0;

for (int i = 85; i <= 907; i ++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
        total += i;
    }
}

Console.WriteLine($"A soma dos valores é igual a: {total}");
