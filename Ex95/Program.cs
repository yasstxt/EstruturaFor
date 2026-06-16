//Para uma turma de 45 alunos, construa um algoritmo que determine: 
//a) A idade média dos alunos com menos de 1,70m de altura;
//b) A altura média dos alunos com mais de 20 anos. 

int idade;
double altura;
int soma;
int alt;

for (int i = 0; i < 45; i++)
{
    Console.WriteLine("Digite sua altura: ");
    altura = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite sua idade: ");
    idade = int.Parse(Console.ReadLine());

    if (altura < 1.70)
    {
        soma += idade;

    }
}

