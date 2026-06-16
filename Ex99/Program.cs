double mediaSal = 0;
string nome;
int qtdfunc;
double salario;
double menor = 0;
double maior = 0;
double somaSal = 0;

Console.WriteLine("Digite a quantidade de funcionários: ");
qtdfunc = int.Parse(Console.ReadLine());

for (int i = 0; i < qtdfunc; i++)
{
    Console.WriteLine("Digite o seu nome: ");
    nome = Console.ReadLine();

    Console.WriteLine("Digite o valor do seu salário: ");
    salario = double.Parse(Console.ReadLine());

    somaSal += salario;

    if (i == 0)
    {
        maior = salario;
        menor = salario;
    } else
    {
        if (salario > maior)
            maior = salario;

        if (salario < menor)
            menor = salario;
    }
}

mediaSal = somaSal / qtdfunc;

Console.WriteLine($"A média dos salários é: {mediaSal}");
Console.WriteLine($"O maior salário é: {maior}");
Console.WriteLine($"O menor salário é: {menor}");