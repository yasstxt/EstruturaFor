//A série de Fibonacci é formada pela sequência: 0, 1, 1, 2, 3, 5, 8, 13, 21, ... 
//Construa um algoritmo que gere e mostre a série até o vigésimo termo.

int primeiro = 0;
int segundo = 1;
int proximo;

for (int i = 3; i <= 20; i++)
{
    proximo = primeiro + segundo;
    Console.Write($" {primeiro}, {segundo}, {proximo}, ");
    primeiro = segundo;
    segundo = proximo;
}

