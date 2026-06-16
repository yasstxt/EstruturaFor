using System.Reflection;
using System.Runtime.Intrinsics.X86;
//Dado o conjunto de instruções a seguir, faça um algoritmo com quatro variações,
//colocando o comando de repetição adequadamente, de forma a: 
//a) Executar o conjunto 10 vezes;
//b) Não executar nenhuma vez;
//c) Executar o conjunto 100 vezes utilizando duas estruturas de repetição;
//d) Executar N vezes, onde N é uma variável informada pelo usuário. 
//- Ler A, B;
//-Modulo = A mod B (calcula o resto da divisão).


Console.WriteLine("Hello, World!");
        int A, B, modulo, N;

        // a) Executar 10 vezes
        Console.WriteLine("A) Executar 10 vezes");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Digite A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite B: ");
            B = int.Parse(Console.ReadLine());

            modulo = A % B;
            Console.WriteLine("Módulo = " + modulo);
        }

        // b) Não executar nenhuma vez
        Console.WriteLine("\nB) Não executar nenhuma vez");
        for (int i = 1; i <= 0; i++)
        {
            Console.Write("Digite A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite B: ");
            B = int.Parse(Console.ReadLine());

            modulo = A % B;
            Console.WriteLine("Módulo = " + modulo);
        }

        // c) Executar 100 vezes usando dois for
        Console.WriteLine("\nC) Executar 100 vezes");
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                Console.Write("Digite A: ");
                A = int.Parse(Console.ReadLine());

                Console.Write("Digite B: ");
                B = int.Parse(Console.ReadLine());

                modulo = A % B;
                Console.WriteLine("Módulo = " + modulo);
            }
        }

        // d) Executar N vezes
        Console.WriteLine("\nD) Executar N vezes");
        Console.Write("Informe N: ");
        N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            Console.Write("Digite A: ");
            A = int.Parse(Console.ReadLine());

            Console.Write("Digite B: ");
            B = int.Parse(Console.ReadLine());

            modulo = A % B;
            Console.WriteLine("Módulo = " + modulo);
        }
    }
