//Dado o conjunto de instruções a seguir, faça um algoritmo com quatro variações,
//colocando o comando de repetição adequadamente, de forma a: 
//a) Executar o conjunto 10 vezes;
//b) Não executar nenhuma vez;
//c) Executar o conjunto 100 vezes utilizando duas estruturas de repetição;
//d) Executar N vezes, onde N é uma variável informada pelo usuário. 
//- Ler A, B;
//-Modulo = A mod B (calcula o resto da divisão).

int A, B, num;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Digite um valor para a: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor para b: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resto da divisão de {a} / {b} é de: {a % b}");
}
for (int i = 0; i < 0; i++)
{
    Console.WriteLine("Digite um valor para a: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor para b: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resto da divisão de {a} / {b} é de: {a % b}");

    for (int x = 0; x < 50; x++)
    {
        Console.WriteLine("Digite um valor para a: ");
        A = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite um valor para b: ");
        B = int.Parse(Console.ReadLine());
        Console.WriteLine($"O resto da divisão de {A} / {B} é de: {A % B}");

        for (int X = 0; X < 50; X++)
        {
            Console.WriteLine("Digite um valor para a: ");
             A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para b: ");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine($"O resto da divisão de {A} / {B} é de: {A % B}");
        }
    }
}
Console.WriteLine("Digite o número de vezes a ser executado: ");
num = int.Parse(Console.ReadLine());


for (int i = 1; i <= num; i++)
{
    Console.WriteLine("Digite um valor para a: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor para b: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine($"O resto da divisão de {a} / {b} é de: {a % b}");
}
