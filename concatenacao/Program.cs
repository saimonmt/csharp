// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//  Concatenacao 04/11/2024
string nome = "Joao ";
string saudacao = "Ola, "+nome+"! Bem-vindo.";
Console.WriteLine(saudacao);

// Interpolacao de Strings
string nome1 = "Jose ";
string saudacao1 = $"Ola, {nome1}! Bem-vindo.";
Console.WriteLine(saudacao1);

// Operador GetType()
int num = 5;
Console.WriteLine(num.GetType() + " Usado para obter o tipo de instancia de um objeto em tempo de execucao");

// Palavra-chave typeof
Console.WriteLine(typeof(int) + " Usado para obter o tipo de uma classe ou estrutura em tempo de compilacao");

//  Metodo Parse
string valorTexto = "100";
Console.WriteLine("A variavel valorTexto e do tipo: "+ valorTexto.GetType());

int num2 = int.Parse(valorTexto);
Console.WriteLine(num2);
Console.WriteLine("A variavel numeroParse é do Tipo: " + num2.GetType());