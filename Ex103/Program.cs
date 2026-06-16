//Um determinado material radioativo perde metade de sua massa a cada 50 segundos. Dada a massa inicial, 
//em gramas, faça um programa que determine o tempo necessário para que essa massa se torne menor que 0,05 gramas.

double massa;
int tempo = 0;
Console.WriteLine("Digite a massa do material radioativo em gramas: ");
massa = double.Parse(Console.ReadLine());

for (; massa >= 0.05; tempo += 50)
{
    massa /= 2;       
}

Console.WriteLine($"O tempo necessário foi de: {tempo} segundos.");
Console.WriteLine($"A massa final foi de:  {massa} gramas");
