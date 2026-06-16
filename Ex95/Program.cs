//Para uma turma de 45 alunos, construa um algoritmo que determine: 
//a) A idade média dos alunos com menos de 1,70m de altura;
//b) A altura média dos alunos com mais de 20 anos. 

int idade;
double altura;
int somaIdade = 0;
double somaAlt = 0;
int menor170 = 0;
int maior20 = 0;
double totalAlt;
int totalIdade;

for (int i = 0; i < 45; i++)
{
    Console.Write("Digite sua altura: ");
    altura = double.Parse(Console.ReadLine());

    Console.Write("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine());

    if (altura < 1.70)
    {
        somaIdade += idade;
        menor170++;
    }

    if (idade > 20)
    {
        somaAlt += altura;
        maior20++;
    }
}

totalAlt = (double)somaIdade / menor170;
totalIdade = (int)somaAlt / maior20;
Console.WriteLine($"Idade média dos alunos com menos de 1,70m: {totalAlt}");
Console.WriteLine($"Altura média dos alunos com mais de 20 anos: {totalIdade}");