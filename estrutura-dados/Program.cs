// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Estruturas de dados
// Exemplo 01: Vetor (Array)
int[] meuArray = new int[5];
meuArray[0] = 10;
meuArray[1] = 20;
meuArray[2] = 30;
meuArray[3] = 40;
meuArray[4] = 50;
Console.WriteLine("Numeros no array:");
for (int i = 0; i < meuArray.Length;i++)
{
    Console.WriteLine(meuArray[i]);
}

//  Criando a lista e adicionando elementos
List<string> listaDeNomes = new List<string> { "Wanderson", "Jeane", "Ryan"} ;
listaDeNomes.Add("Maria");
//Exibindo a lista inicial
Console.WriteLine("Nomes na lista:");
for(int i = 0; i < listaDeNomes.Count;i++)
{   
    Console.WriteLine(listaDeNomes[i]);
}


//  Verificar se o nome esta na Lista
Console.WriteLine("\nVerificacao de existencia do nome Ryan:");
string nomeParaVerificar = "Ryan";
if(listaDeNomes.Contains(nomeParaVerificar))
{
    Console.WriteLine($"{nomeParaVerificar} esta na lista.");
}
else
{
    Console.WriteLine($"{nomeParaVerificar} nao esta na lista.");
}

//  Remover um nome da Lista
Console.WriteLine("\nApos remover Wanderson:");
string nomeParaRemover = "Wanderson";
bool foiRemovido = listaDeNomes.Remove(nomeParaRemover);
if(foiRemovido)
{
    Console.WriteLine($"{nomeParaRemover} foi removido da lista.");
}
else
{
    Console.WriteLine($"{nomeParaRemover} nao foi encontrado na lista.");
}

//  Exibindo a lista final apos a remocao 
Console.WriteLine("\nNomes na lista apos a remocao:");
for (int i = 0; i < listaDeNomes.Count;i++)
{
    Console.WriteLine(listaDeNomes[i]);
}

// Conjunto (Set)
// Conjunto (Set) os elementos sao unicos, ou seja, nao permite inserir elementos repetidos no conjunto. 
HashSet<int> conjunto = new HashSet<int> {1,2,3};
conjunto.Add(4);
conjunto.Add(2);
Console.WriteLine("\nElementos do Conjunto:");
foreach (int elemento in conjunto)
{
    Console.WriteLine(elemento);
}

HashSet<string> frutas = new HashSet<string> {"Maca","Banana","Laranja","Abacaxi"};
frutas.Add("Uva");
frutas.Add("Maca");
Console.WriteLine("\nFrutas no Conjunto:");
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}
frutas.Remove("Banana");
Console.WriteLine("\nVerificacao de existencia:");
Console.WriteLine(frutas.Contains("Banana") ? "Banana esta no conjunto":"Banana nao esta no conjunto");
frutas.Remove("Laranja");
Console.WriteLine("\nApos remover Laranja:");
foreach (string fruta in frutas)
{
    Console.WriteLine(fruta);
}

// Exercicios 
// 1. Dado um array de inteiros int[] numeros {1,2,3,4,5};, escreva um codigo que some todos os elementos do array e exiba o 
// resultado no console.
int soma1 =0;
int[] exerc1 = new int[5];
exerc1[0] = 1;
exerc1[1] = 2;
exerc1[2] = 3;
exerc1[3] = 4;
exerc1[4] = 5;
Console.WriteLine("\n Exercicio numero 1 do array:");
for (int i = 0; i < exerc1.Length;i++)
{
    soma1 = soma1+exerc1[i];
}
Console.WriteLine(soma1);

// Resolucao do Professor
int[] numeros = {1,2,3,4,5};
int soma = 0;
foreach(int numero in numeros)
    {
        soma+=numero;
    }
Console.WriteLine(soma);
// 2. Dada uma lista de strings List<string> nomes = new List<string> {"Jeane","Wanderson","Jeane","Ryan","Jeane"};, escreva 
// um codigo para contar quantas vezes o nome "Jeane" aparece na lista.
int ci = 0;
List<string> exerc2 = new List<string> {"Jeane","Wanderson","Jeane","Ryan","Jeane"} ;
string nomeParaVer2 = "Jeane";

foreach(string nome2 in exerc2)
    {
        if(nomeParaVer2.Contains(nome2))
        {
            ci++;
        }
    }
    Console.WriteLine($"\nO nome {nomeParaVer2} esta com a qtde {ci} vezes no exercicio2.");


// 3. Dada uma lista de inteiros com elementos duplicados List<int> numeros = new List<int> {1,2,2,3,4,4,5};, escreva um 
// codigo para remover os elementos duplicados e exibir a lista sem duplicatas. 
// int iv = 0;
// List<int> exerc3 = new List<int> {1,2,2,3,4,4,5} ;
// for(int i3 = 0; i3 < exerc3.Count;i3++)
// {   
//     iv = exerc3[i3];
//     if(iv.Contains(exerc3))
//         {
//             exerc3.Remove(exerc3[i3]);
//         }
// }

// Console.WriteLine($"\nO nome{nomeParaVer2} esta com a qtde {ci} vezes no exercicio2.");
List<int> exerc3 = new List<int> {1,2,2,3,4,4,5} ;
HashSet<int> conj3 = new HashSet<int>(exerc3);
Console.WriteLine("\nExercicio n 3:");
foreach (int elem3 in conj3)
{
    Console.WriteLine(elem3);
}

// 4. Dado um conjunto HashSet<string> frutas = new HashSet<string> {"Maca", "Banana","Laranja"};, escreva um codigo que verifique 
// se "Banana" esta no conjunto e exiba uma mensagem no console. 
HashSet<string> exerc4 = new HashSet<string> {"Maca","Banana","Laranja","Abacaxi"};
exerc4.Add("Uva");
exerc4.Add("Maca");
Console.WriteLine("\n Exercicio 4 - Frutas no Conjunto:");
foreach (string exer4 in exerc4)
{
    Console.WriteLine(exer4);
}
Console.WriteLine("\nVerificacao de existencia:");
Console.WriteLine(exerc4.Contains("Banana") ? "Banana esta no conjunto":"Banana nao esta no conjunto");

// 5. Crie uma lista vazia de numeros inteiros List<int> numeros = new List<int>();. Em seguida, adicione os numeros de 1 a 5 na lista
// e exiba os elementos no console
List<int> exerc5 = new List<int>();
// exerc5.Add(1);
// exerc5.Add(2);
// exerc5.Add(3);
// exerc5.Add(4);
// exerc5.Add(5);
for(int i = 1; i <= 5;i++)
 {   
     exerc5.Add(i);
 }
Console.WriteLine("Exercicio 5 - Itens na lista:");
// for(int i = 0; i < exerc5.Count;i++)
// {   
//     Console.WriteLine(exerc5[i]);
// }
foreach (int exer5 in exerc5)
{
    Console.WriteLine(exer5);
}