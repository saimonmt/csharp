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

//  Cast/Casting (Conversao de um numero do tipo string para int, float ou double usando convert )
string valorEmTexto = "100";
Console.WriteLine("A variavel valorTexto é do tipo:" + valorEmTexto.GetType());

int numeroConvertido = Convert.ToInt32(valorEmTexto);
Console.WriteLine(numeroConvertido);
Console.WriteLine("A variavel numeroConvertido é do tipo:" + numeroConvertido.GetType());

//  Metodo ToString
int num3 = 123 ;
Console.WriteLine(num3.GetType());

string numeroComoString = num3.ToString();
Console.WriteLine(numeroComoString.GetType());

//  Personalizacao de formatacao para data e hora
DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

string dataFormatada =dataAtual.ToString("dd/MM/yyyy");
Console.WriteLine(dataFormatada);

string dataHoraFormatada =dataAtual.ToString("dd/MM/yyyy HH:mm");
Console.WriteLine(dataHoraFormatada);

string HoraFormatada =dataAtual.ToString("HH:mm");
Console.WriteLine(HoraFormatada);

string HoraFormat =dataAtual.ToString("HH:mm:ss");
Console.WriteLine(HoraFormat);

//  Metodo ToString -  Interpolacao de String 
double preco = 29.99;
Console.WriteLine($"O preço é: {preco.ToString("C2")}");

double preco1 = 29.99;
Console.WriteLine($"O preço é: {preco1.ToString("C3")}");

//  Formatacao de acordo com a localizacao (using System.Globalization )
decimal valor = 1234.56m;
string valorUS = valor.ToString("C", new System.Globalization.CultureInfo("en-US"));
Console.WriteLine(valorUS);

string valorBR = valor.ToString("C", new System.Globalization.CultureInfo("pt-BR"));
Console.WriteLine(valorBR);