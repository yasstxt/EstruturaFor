using System.Diagnostics;
//Um hotel com 30 quartos cobra R$ 50,00 por diária e mais uma taxa de serviços. A taxa de serviços é de: 
//• R$ 4,00 por diária, se o número de diárias for < 15; 
//• R$ 3,60 por diária, se o número de diárias for = 15; 
//• R$ 3,00 por diária, se o número de diárias for > 15.

string nome;
int dias;
double totalHotel = 0;
double taxadiaria;

for (int cliente = 1; cliente <= 30; cliente++)
{
    Console.Write("Digite o seu nome: ");
    nome = Console.ReadLine();
    Console.Write("Quantidade de diárias: ");
    dias = int.Parse(Console.ReadLine());
    Console.WriteLine($"Cliente: {nome}");


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
    Console.WriteLine($"O valor final da diária é de: R$ {total}");
    totalHotel += total;
}

Console.WriteLine($"O valor total que o hotel ganhou é de: R$ {totalHotel}");
