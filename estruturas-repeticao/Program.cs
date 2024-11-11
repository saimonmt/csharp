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
// Estrutura de Repeticao for
    else if (tpRetExerc == "3")
    {
        for(int i=0;i<=10;i++)
        {
            Console.WriteLine($"Valor de i: {i}");
        }
    }
// Estrutura de Repeticao ForEach
    else if (tpRetExerc == "4")
    {    
        string[] nomes = {"Wanderson","Jeane","Ryan"};
        foreach (string nome in nomes)
        {
            Console.WriteLine(nome);
        }
    }


    // 1- Crie um algoritmo que some todos os numeros pares de 1 a 100 e exiba o resultado no console. 
    // 2- Crie um algoritmo que faca uma contagem regressiva de 10 a 1 e exiba "Decolar!" ao final. 
    // 3- Crie um algoritmo que conte o numero de vogais (a, e, i, o, u) na palavra e exiba o resultado. 
    // 4- Crie um algoritmo que solicite uma palavra ou frase do usuario, verifique se é um palidromo, ou seja, se é igaul de tras para frente. Exemplo:ana, radar etc...
    // 5- Crie um algoritmo onde o computador escolhe um numero aleatorio entre 1 e 100, e o usuario deve adivinhar. Apos cada tentativa, o programa indica se o numero é maior ou menor. 

    //Exerc 5 .
    else if (tpRetExerc == "5")
    {
        Random numeroAleatorio = new Random();
        int num3 = numeroAleatorio.Next(1,101);
        int numusu;
        Console.WriteLine("Adivinhe o numero aleatorio entre 1 e 100 ");
        string? cRet = Console.ReadLine();
        numusu = int.Parse(cRet);
        while (numusu != num3)
        {
            if(numusu > num3 )
                {
                    Console.WriteLine("Valor Menor");
                    cRet = Console.ReadLine();
                    numusu = int.Parse(cRet);
                }
                else
                {
                    Console.WriteLine("Valor Maior");
                    cRet = Console.ReadLine();
                    numusu = int.Parse(cRet);
                }
        }
        
    }
    // Exerc 1
    else if (tpRetExerc == "6")
    {
        int num4 = 0;
        int totsoma = 0 ; 
         for(int i=0;i<=100;i++)
        {
            num4 = i % 2 ;
            if(num4 == 0 )
            {
                totsoma = totsoma + i;
            }
        }
        Console.WriteLine($"A soma dos numeros pares é: {totsoma}");
    }
    // Exerc 2
    else if (tpRetExerc == "7")
    {
        for(int i=10;i>=0;i--)
        {   
            if(i > 0 )
            {
                Console.WriteLine($"Contagem : {i}");
            }
            else
            {
                Console.WriteLine("Decolar!");
            }
        }
    }
    //  Exerc 3
    else if (tpRetExerc == "8")
    {
        Console.WriteLine("Digite uma palavra para contar as vogais");
        string? cRet2 = Console.ReadLine();
        string letraMinuscula = cRet2.ToLower();
        int num5 = letraMinuscula.Length;
        int numVog = 0;
        int numConsoante = 0;
        string? cQuebra = "";
        for(int i=1;i<=num5;i++)
        {
            cQuebra = letraMinuscula
            switch (letraMinuscula)
            {
            case "a":
            case "e":
            case "i":
            case "o":
            case "u":
                //Console.WriteLine($"A letra '{letraMinuscula}' é uma vogal.");
                numVog++;
                break;
            default:
                //Console.WriteLine($"A letra '{letraMinuscula}' nao é uma vogal.");
                numConsoante++;
                break;
            }
            
        }
        Console.WriteLine($"O numero de vogal é: {numVog}");
        Console.WriteLine($"O numero de consoante é: {numConsoante}");

    }
