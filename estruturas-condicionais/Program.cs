﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Estruturas Condicionais 06/11/2024
double nota1 = 5.5;
double nota2 = 8.0;
double nota3 = 6.8;
double media = (nota1 + nota2 + nota3) / 3;
if (media >= 7)
{
    Console.WriteLine($"Media {media:F2}: Aprovado");
}
else
{
    Console.WriteLine($"Media {media:F2}: Recuperacao");
}

double nota21 = 8;
double nota22 = 8.0;
double nota23 = 5.0;
double media2 = (nota21 + nota22 + nota23) / 3;
if (media2 >= 7)
{
    Console.WriteLine($"Media {media2:F2}: Aprovado");
}
else if (media2 >= 5 && media2 < 7 )
{
    Console.WriteLine($"Media {media2:F2}: Recuperacao");
}
else
{
    Console.WriteLine($"Media {media2:F2}: Reprovado");
}

Console.WriteLine("Digite uma vogal");
string? letra = Console.ReadLine();
if(letra == "a" || letra == "A")
{
    Console.WriteLine($"Voce digitou a vogal: {letra} ");
}
else if(letra == "e" || letra == "E")
{
    Console.WriteLine($"Voce digitou a vogal: {letra} ");
}
else if(letra == "i" || letra == "I")
{
    Console.WriteLine($"Voce digitou a vogal: {letra} ");
}
else if(letra == "o" || letra == "O")
{
    Console.WriteLine($"Voce digitou a vogal: {letra} ");
}
else if(letra == "u" || letra == "U")
{
    Console.WriteLine($"Voce digitou a vogal: {letra} ");
}
else
{
    Console.WriteLine($"A letra {letra} nao e uma vogal");
}


string dia = "Sábado";

switch (dia)
{
    case "Sábado":
        Console.WriteLine("Sábadoooo galera!");
        break;
    case "Domingo":
        Console.WriteLine("Domingao, hoje é dia de assitir a Temperatura Maxima !");
        break;
    default:
        Console.WriteLine("Hoje é dia de semana, para de preguica, levanta e vai trabalhar!");
        break;
}


Console.WriteLine("Digite uma vogal:");
string? letra2 = Console.ReadLine();
string letraMinuscula = letra2.ToLower();
//string letraMaisucula = letra2.ToUpper();
switch (letraMinuscula)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine($"A letra '{letraMinuscula}' é uma vogal.");
        break;
    default:
        Console.WriteLine($"A letra '{letraMinuscula}' nao é uma vogal.");
        break;
}
//  Operador Ternario
int idade = 18;
string mensagem = idade >= 18 ? "Maior de idade" : "Menor de idade";
Console.WriteLine(mensagem);

