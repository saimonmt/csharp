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