// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//Exercicio 1
Console.WriteLine("Informe qual o exercicio?");
string? tpRetExerc = Console.ReadLine();
    if (tpRetExerc == "1")
    {
        Console.WriteLine("Tipo 1 ou 2 do Exercicio 1");
        string? tpRet = Console.ReadLine();
            if (tpRet == "1")
            {
                string cRet ;
                Console.WriteLine("Maior que 18 anos?");
                string? maiorDezoito = Console.ReadLine();
                Console.WriteLine("Possuiu autorizacao do responsavel?");
                string? autorizaResponsavel = Console.ReadLine();
                if( maiorDezoito == "s" || autorizaResponsavel == "s" )
                    {
                        cRet = "Entrada Liberada.";
                    }
                else
                    {
                        cRet = "Entrada nao permitida.";
                    }

                Console.WriteLine(cRet);
            }
            else
            {
                bool lmaiorDezoito = true;
                bool lautorizaResponsa = true;
                string mensagem = lmaiorDezoito ||lautorizaResponsa ? "Entrada Liberada" : "Entrada nao permitida";
                Console.WriteLine(mensagem);
            }
    }
    ////Exercicio 2 
    else if (tpRetExerc == "2")
    {
        Console.WriteLine("Tipo 1 ou 2 do Exercicio 2");
        string? tpRet2 = Console.ReadLine();
            if (tpRet2 == "1")
            {
                string cRet2 ;
                Console.WriteLine("Possuiu presenca minima?");
                string? presencaMinima = Console.ReadLine();
                Console.WriteLine("Possui media igual ou maior que 7?");
                string? mediaMaiorIgual = Console.ReadLine();
                if( presencaMinima == "s" && mediaMaiorIgual == "s" )
                    {
                        cRet2 = "Aprovado.";
                    }
                else
                    {
                        cRet2 = "Reprovado.";
                    }

                Console.WriteLine(cRet2);
            }
            else
            {
                bool lPresMin = true;
                bool lMediaIgualMaior = true;
                string mensagem = lPresMin && lMediaIgualMaior ? "Aprovado" : "Reprovado";
                Console.WriteLine(mensagem);
            }
    }

    ////Exercicio 3 
    else if (tpRetExerc == "3")
    {
        bool posuiPresencaMinima = true;
        double media3 = 7.0;
        if (posuiPresencaMinima && media3>= 7 )
        {
            Console.WriteLine($"Media {media3:F1} : Aprovado");
        }
        else
        {
            Console.WriteLine($"Media {media3:F1} : Reprovado");
        }
    }
    ////Exercicio 4
    else if (tpRetExerc == "4")
    {
         Console.WriteLine("Tipo 1 , 2 ou 3 do Exercicio 4");
        string? tpRet2 = Console.ReadLine();
            if (tpRet2 == "1")
            {
                string cRet3 ;
                Console.WriteLine("Choveu?");
                string? cChoveu = Console.ReadLine();
                Console.WriteLine("Esta tarde?");
                string? cEstaTarde = Console.ReadLine();
                if (! (cChoveu == "s" && cEstaTarde == "s"))
                    {
                        cRet3 = "Vou Pedalar.";
                    }
                else
                    {
                        cRet3 = "Vou Pedalar outro dia.";
                    }

                Console.WriteLine(cRet3);
            }
            else if (tpRet2 == "2")
            {
                bool lChoveu = false;
                bool lEstaTarde = false;
                string mensagem = !(lChoveu && lEstaTarde) ? "Vou Pedalar" : "Vou Pedalar outro dia";
                Console.WriteLine(mensagem);
            }
            else  //resolucao do Professor
            {
                bool choveu = true;
                bool estaTarde = false;
                if(!choveu && !estaTarde)
                {
                    Console.WriteLine("Vou pedalar");
                }
                else
                {
                    Console.WriteLine("Vou pedalar outro dia");
                }
            }
    }