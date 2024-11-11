// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// Estrutura de Repeticao while 11/11/2024;
Console.WriteLine("Informe qual estrutura ?");
string? tpRetExerc = Console.ReadLine();
    if (tpRetExerc == "1")
    {
        Random numeroAleatorio = new Random();
        int numero = numeroAleatorio.Next(1,101);
        int contador = 0;
        Console.WriteLine($"Numero Algo: {numero}");
        // Loop que incrementa o contador ate ele atingir o numero alvo
        while (contador != numero)
        {
            Console.WriteLine($"Contador: {contador}.");
            contador++;
        }
        Console.WriteLine($"Contador atingiu o numero alvo: {contador}");
    }
// Estrutura de Repeticao do-while
    else if (tpRetExerc == "2")
    {
        int num2 = 0;
        do
        {
            Console.WriteLine($"Numero: {num2}");
            num2++;
        } while (num2 < 10) ; 
    }

