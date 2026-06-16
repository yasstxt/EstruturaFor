double A = 0;
int N;
Console.Write("Digite um valor para N: ");
N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    A += (double)(N - i + 1) / i;
}

Console.WriteLine($"Valor de A é de: {A}");
