using System.Diagnostics;
string nome;
int dias;
double totalHotel = 0;
double taxadiaria;

for (int cliente = 1; cliente <= 30; cliente++)
{
    Console.WriteLine($"Cliente: {cliente}");

    Console.Write("Digite o seu nome: ");
    nome = Console.ReadLine();
    Console.Write("Quantidade de diárias: ");
    dias = int.Parse(Console.ReadLine());

    if (dias < 15)
    {
        taxadiaria = dias * 4.00;
    } else if (dias == 15)
    {
        taxadiaria = dias * 3.60;
    } else
    {
        taxadiaria = dias * 3.00;
    }

    double total = (dias * 50.00) + taxadiaria;
    Console.WriteLine($"Cliente: {nome}");
    Console.WriteLine($"Total da diária: R$ {total}");
    totalHotel += total;
}

Console.WriteLine($"O valor que total que o hotel ganhou é de: R$ {totalHotel}");
